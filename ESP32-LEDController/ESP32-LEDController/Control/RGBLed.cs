using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices;

namespace ESP32_LEDController.Control
{
    public partial class RGBLed : UserControl
    {
        public int Loc { get; set; }
        public bool IsClicked { get; set; }

        ServiceClient serviceClient;

        public RGBLed(int loc)
        {
            this.Loc = loc;
            InitializeComponent();
        }

        private async Task SendInstruction()
        {
            string matrixdata = (Loc - 1).ToString() + "|" + Global.R + "|" + Global.G + "|" + Global.B;
            var commandMessage = new Microsoft.Azure.Devices.Message(Encoding.ASCII.GetBytes(matrixdata));
            await serviceClient.SendAsync(Global.DeviceId, commandMessage);
        }

        private async void RGBLed_MouseClickAsync(object sender, MouseEventArgs e)
        {
            if (!Global.ValidateSettings())
            {
                MessageBox.Show("There are some invalid settings!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsClicked)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Red;
                IsClicked = true;
            }

            serviceClient = ServiceClient.CreateFromConnectionString(Global.ConnectionString);
            await SendInstruction();
        }
    }
}
