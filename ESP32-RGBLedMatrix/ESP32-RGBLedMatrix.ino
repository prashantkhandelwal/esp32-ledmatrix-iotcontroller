#include <Adafruit_NeoPixel.h>
#include <ArduinoJson.h>
#include <PubSubClient.h>
#include <WiFiClientSecure.h>

#define PIN 5

const char *ssid = "GHOST";
const char *password = "supernova581";
const char *mqtt_server = "esp-iot.azure-devices.net";
const char *deviceID = "esp32";
const char *hubUser =
    "esp-iot.azure-devices.net/esp32/api-version=2016-11-14"; // /api-version=2016-11-14
const char *hubPassword = "SharedAccessSignature "
                          "sr=esp-iot.azure-devices.net&sig=txJn2GJs4%2BFmG%"
                          "2FNwbQRpW0%2B%2FKbkVXNXBqQHAlg6H0xg%3D&se="
                          "1549881942&skn=iothubowner";
char *direct_method_body;

Adafruit_NeoPixel strip = Adafruit_NeoPixel(64, PIN, NEO_GRB + NEO_KHZ800);
WiFiClientSecure wificlient;
PubSubClient clientMqtt(wificlient);
StaticJsonBuffer<100> jsonBuffer;

void callback(char *topic, byte *payload, unsigned int length) {
  Serial.println("Received some data");

  char data[50];

  // Check for the topic. If it contains "methods".
  if (strstr(topic, "methods") != NULL) {
    // Can have additonal checks to get the method name.
    // We can also rely on the method body.
    // As we already know that this is a direct method invocation.
    int k;
    for (k = 0; k < length; k++) {
      data[k] = payload[k];
    }

    data[k] = '\0';

    Serial.println(data);

    JsonObject &root = jsonBuffer.parseObject(data);

    if (!root.success()) {
      Serial.println("failed");
    }

    const char *command = root["command"];

    // TODO: Replace it with switch case
    if (strstr(command, "rainbow")) {
      rainbow(20);
    }

    // TODO: Add a check if the publish was successfull.
    clientMqtt.publish("$iothub/methods/res/200/?$rid=1", "Method Executed!");

  } else {

    char strs[10][10];
    int i, a, ctr, L, R, G, B;

    for (i = 0; i < length; i++) {
      data[i] = payload[i];
    }

    data[i] = '\0';

    Serial.println(data);

    a = 0;
    ctr = 0;
    for (int d = 0; d <= (strlen(data)); d++) {
      if (data[d] == '|' || data[d] == '\0') {
        strs[ctr][a] = '\0';
        ctr++;
        a = 0;
      } else {
        strs[ctr][a] = data[d];
        a++;
      }
    }

    // Led
    L = atoi(strs[0]); // (int)strs[0] - '0'

    // Red
    R = atoi(strs[1]);

    // Green
    G = atoi(strs[2]);

    // Blue
    B = atoi(strs[3]);

    MatrixControl(L, R, G, B);
  }
}

void setup_wifi() {
  delay(10);
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);
  // WiFi.mode(WIFI_STA);
  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
}

void reconnect() {
  while (!clientMqtt.connected()) {
    Serial.print("Attempting MQTT connection...");
    // Attempt to connect
    if (clientMqtt.connect(deviceID, hubUser, hubPassword)) {
      Serial.println("connected");
      // String data = "{\"data\":\"hello\",\"device\":\"esp32\"}";
      // int i =
      // clientMqtt.publish("devices/esp32/messages/events/device=esp32",
      //                            data.c_str());

      // Serial.print(String(i));

      if (clientMqtt.subscribe("$iothub/methods/POST/#")) {
        Serial.println("Direct Method");
      }

      if (clientMqtt.subscribe("devices/esp32/messages/devicebound/#")) {
        Serial.println("Subscribed successfully");
      }

    } else {
      Serial.print("failed, rc=");
      Serial.print(clientMqtt.state());
      Serial.println(" try again in 5 seconds");
      delay(5000);
    }
  }
}

void rainbow(uint8_t wait) {
  uint16_t i, j;

  for (int j = 0; j < 256; j++) {
    for (int i = 0; i < strip.numPixels(); i++) {
      strip.setPixelColor(i, Wheel(((i * 256 / strip.numPixels()) + j) & 255));
    }
    strip.show();
    delay(wait);
  }
}

uint32_t Wheel(byte WheelPos) {
  if (WheelPos < 85) {
    return strip.Color(WheelPos * 3, 255 - WheelPos * 3, 0);
  } else if (WheelPos < 170) {
    WheelPos -= 85;
    return strip.Color(255 - WheelPos * 3, 0, WheelPos * 3);
  } else {
    WheelPos -= 170;
    return strip.Color(0, WheelPos * 3, 255 - WheelPos * 3);
  }
}

void setup() {
  Serial.begin(115200);
  setup_wifi();
  clientMqtt.setClient(wificlient);
  clientMqtt.setServer(mqtt_server, 8883);
  clientMqtt.setCallback(callback);
  strip.begin();
}

void MatrixControl(int led, int R, int G, int B) {
  delay(10);
  strip.show();

  //Serial.println("Hello: " + String(led));
  strip.setPixelColor(led, strip.Color(R, G, B));
  //delay(10);
  strip.show();
}

void loop() {
  if (!clientMqtt.connected()) {
    Serial.print("Loop_Reconnect.!. ");
    reconnect();
  }
  clientMqtt.loop();
}
