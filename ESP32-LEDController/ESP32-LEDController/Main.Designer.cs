namespace ESP32_LEDController
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ledPanel = new System.Windows.Forms.Panel();
            this.gbconfig = new System.Windows.Forms.GroupBox();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.gbMethods = new System.Windows.Forms.GroupBox();
            this.txtRGBVal = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblLED = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbconfig.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // ledPanel
            // 
            this.ledPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ledPanel.Location = new System.Drawing.Point(316, 18);
            this.ledPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledPanel.Name = "ledPanel";
            this.ledPanel.Size = new System.Drawing.Size(255, 269);
            this.ledPanel.TabIndex = 0;
            // 
            // gbconfig
            // 
            this.gbconfig.Controls.Add(this.txtDeviceId);
            this.gbconfig.Controls.Add(this.label2);
            this.gbconfig.Controls.Add(this.txtConnectionString);
            this.gbconfig.Controls.Add(this.label1);
            this.gbconfig.Location = new System.Drawing.Point(18, 340);
            this.gbconfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbconfig.Name = "gbconfig";
            this.gbconfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbconfig.Size = new System.Drawing.Size(834, 128);
            this.gbconfig.TabIndex = 1;
            this.gbconfig.TabStop = false;
            this.gbconfig.Text = "IoTHub Configuration";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(177, 80);
            this.txtDeviceId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(646, 26);
            this.txtDeviceId.TabIndex = 3;
            this.txtDeviceId.Leave += new System.EventHandler(this.txtDeviceId_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Device ID";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(177, 40);
            this.txtConnectionString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(646, 26);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Leave += new System.EventHandler(this.txtConnectionString_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.chkAuto);
            this.gbSettings.Location = new System.Drawing.Point(18, 477);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSettings.Size = new System.Drawing.Size(396, 257);
            this.gbSettings.TabIndex = 2;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(13, 44);
            this.chkAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(248, 24);
            this.chkAuto.TabIndex = 0;
            this.chkAuto.Text = "Send Command Automatically";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // gbMethods
            // 
            this.gbMethods.Controls.Add(this.txtRGBVal);
            this.gbMethods.Controls.Add(this.radioButton2);
            this.gbMethods.Controls.Add(this.radioButton1);
            this.gbMethods.Location = new System.Drawing.Point(456, 477);
            this.gbMethods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMethods.Name = "gbMethods";
            this.gbMethods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMethods.Size = new System.Drawing.Size(396, 257);
            this.gbMethods.TabIndex = 3;
            this.gbMethods.TabStop = false;
            this.gbMethods.Text = "Methods";
            // 
            // txtRGBVal
            // 
            this.txtRGBVal.ForeColor = System.Drawing.Color.Gray;
            this.txtRGBVal.Location = new System.Drawing.Point(154, 42);
            this.txtRGBVal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRGBVal.Name = "txtRGBVal";
            this.txtRGBVal.Size = new System.Drawing.Size(230, 26);
            this.txtRGBVal.TabIndex = 2;
            this.txtRGBVal.Text = "e.g.: 255,255,255";
            this.txtRGBVal.Enter += new System.EventHandler(this.txtRGBVal_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 43);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Light All LEDs";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 80);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(210, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Random Animation Loop";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(380, 297);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 35);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send Sketch";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblLED
            // 
            this.lblLED.AutoSize = true;
            this.lblLED.Location = new System.Drawing.Point(729, 49);
            this.lblLED.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLED.Name = "lblLED";
            this.lblLED.Size = new System.Drawing.Size(50, 20);
            this.lblLED.TabIndex = 5;
            this.lblLED.Text = "LED#";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(734, 77);
            this.txtR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(61, 26);
            this.txtR.TabIndex = 6;
            this.txtR.Leave += new System.EventHandler(this.txtR_Leave);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(734, 117);
            this.txtG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(61, 26);
            this.txtG.TabIndex = 7;
            this.txtG.Leave += new System.EventHandler(this.txtG_Leave);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(734, 157);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(61, 26);
            this.txtB.TabIndex = 8;
            this.txtB.Leave += new System.EventHandler(this.txtB_Leave);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(702, 82);
            this.lblR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(21, 20);
            this.lblR.TabIndex = 9;
            this.lblR.Text = "R";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(702, 122);
            this.lblG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(22, 20);
            this.lblG.TabIndex = 10;
            this.lblG.Text = "G";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(702, 162);
            this.lblB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(20, 20);
            this.lblB.TabIndex = 11;
            this.lblB.Text = "B";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(730, 297);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset Matrix";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 752);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblLED);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.gbMethods);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbconfig);
            this.Controls.Add(this.ledPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESP32 - WS2812 - LED Matrix - IoT Controller";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbconfig.ResumeLayout(false);
            this.gbconfig.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbMethods.ResumeLayout(false);
            this.gbMethods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ledPanel;
        private System.Windows.Forms.GroupBox gbconfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbMethods;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtRGBVal;
        private System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lblLED;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnReset;
    }
}

