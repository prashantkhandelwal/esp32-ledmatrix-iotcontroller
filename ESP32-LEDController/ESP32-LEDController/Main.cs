using System;
using System.Drawing;
using System.Windows.Forms;
using ESP32_LEDController.Control;

namespace ESP32_LEDController
{
    public partial class Main : Form
    {
        int ledMatrix_col = 8;
        int ledMatrix_row = 8;
        int wSpace = 5;
        int loc = 0;
        int matrixLoc = 0;
        int yLoc = 0;
        int xLoc = 0;
        Point ledPoint = new Point();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < ledMatrix_row; j++)
            {
                ledPoint.Y = yLoc + 15;
                ledPoint.X = 0;
                xLoc = 0;
                wSpace = 5;

                for (int i = 0; i < ledMatrix_col; i++)
                {
                    loc = matrixLoc + 1;

                    if (i == 0)
                    {
                        yLoc = ledPoint.Y;
                    }

                    ledPoint.X = xLoc + 10 + wSpace;

                    RGBLed rgb_led = new RGBLed(loc);

                    rgb_led.Location = ledPoint;

                    wSpace = wSpace + 15;

                    ledPanel.Controls.Add(rgb_led);

                    matrixLoc++;
                }
            }
        }

        private void txtRGBVal_Enter(object sender, EventArgs e)
        {
            if (txtRGBVal.Text == "" || txtRGBVal.ForeColor == Color.Gray)
            {
                txtRGBVal.Text = "e.g.: 255,255,255";
                txtRGBVal.ForeColor = Color.Gray;
            }
            else
            {
                txtRGBVal.ForeColor = Color.Black;
                txtRGBVal.Text = "";
            }
        }

        private void txtConnectionString_Leave(object sender, EventArgs e)
        {
            Global.ConnectionString = txtConnectionString.Text;
        }

        private void txtDeviceId_Leave(object sender, EventArgs e)
        {
            Global.DeviceId = txtDeviceId.Text;
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            Global.IsAuto = chkAuto.Checked;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control ctrl in ledPanel.Controls)
            {
                ctrl.BackColor = Color.White;
            }
        }

        private void txtR_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtR.Text))
            {
                Global.R = "0";
            }
            else
            {
                Global.R = txtR.Text;
            }
        }

        private void txtG_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtG.Text))
            {
                Global.G = "0";
            }
            else
            {
                Global.G = txtG.Text;
            }
        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtB.Text))
            {
                Global.B = "0";
            }
            else
            {
                Global.B = txtB.Text;
            }
        }
    }
}
