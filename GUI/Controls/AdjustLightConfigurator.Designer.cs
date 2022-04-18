namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    partial class AdjustLightConfigurator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.trkColorTemperature = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trkHue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trkSaturation = new System.Windows.Forms.TrackBar();
            this.trkBrightness = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLights = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlBridge = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkColorTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.trkColorTemperature);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.trkHue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.trkSaturation);
            this.panel1.Controls.Add(this.trkBrightness);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlLights);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddlBridge);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 553);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Color Temperature:";
            // 
            // trkColorTemperature
            // 
            this.trkColorTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkColorTemperature.Location = new System.Drawing.Point(183, 353);
            this.trkColorTemperature.Maximum = 100;
            this.trkColorTemperature.Minimum = -100;
            this.trkColorTemperature.Name = "trkColorTemperature";
            this.trkColorTemperature.Size = new System.Drawing.Size(695, 45);
            this.trkColorTemperature.SmallChange = 5;
            this.trkColorTemperature.TabIndex = 18;
            this.trkColorTemperature.TickFrequency = 5;
            this.trkColorTemperature.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkColorTemperature.Scroll += new System.EventHandler(this.Trackbar_Scrolled);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hue:";
            // 
            // trkHue
            // 
            this.trkHue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkHue.Location = new System.Drawing.Point(183, 302);
            this.trkHue.Maximum = 100;
            this.trkHue.Minimum = -100;
            this.trkHue.Name = "trkHue";
            this.trkHue.Size = new System.Drawing.Size(695, 45);
            this.trkHue.SmallChange = 5;
            this.trkHue.TabIndex = 16;
            this.trkHue.TickFrequency = 5;
            this.trkHue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkHue.Scroll += new System.EventHandler(this.Trackbar_Scrolled);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Saturation:";
            // 
            // trkSaturation
            // 
            this.trkSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkSaturation.Location = new System.Drawing.Point(183, 251);
            this.trkSaturation.Maximum = 100;
            this.trkSaturation.Minimum = -100;
            this.trkSaturation.Name = "trkSaturation";
            this.trkSaturation.Size = new System.Drawing.Size(695, 45);
            this.trkSaturation.SmallChange = 5;
            this.trkSaturation.TabIndex = 14;
            this.trkSaturation.TickFrequency = 5;
            this.trkSaturation.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkSaturation.Scroll += new System.EventHandler(this.Trackbar_Scrolled);
            // 
            // trkBrightness
            // 
            this.trkBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkBrightness.Location = new System.Drawing.Point(183, 200);
            this.trkBrightness.Maximum = 100;
            this.trkBrightness.Minimum = -100;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Size = new System.Drawing.Size(695, 45);
            this.trkBrightness.SmallChange = 5;
            this.trkBrightness.TabIndex = 13;
            this.trkBrightness.TickFrequency = 5;
            this.trkBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkBrightness.Scroll += new System.EventHandler(this.Trackbar_Scrolled);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Brightness:";
            // 
            // pnlLights
            // 
            this.pnlLights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLights.Location = new System.Drawing.Point(121, 36);
            this.pnlLights.Name = "pnlLights";
            this.pnlLights.Size = new System.Drawing.Size(757, 156);
            this.pnlLights.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lights:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bridge:";
            // 
            // ddlBridge
            // 
            this.ddlBridge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlBridge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ddlBridge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBridge.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddlBridge.Icon = null;
            this.ddlBridge.Location = new System.Drawing.Point(121, 4);
            this.ddlBridge.Name = "ddlBridge";
            this.ddlBridge.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.ddlBridge.SelectedIndex = -1;
            this.ddlBridge.SelectedItem = null;
            this.ddlBridge.Size = new System.Drawing.Size(757, 26);
            this.ddlBridge.TabIndex = 1;
            // 
            // AdjustLightConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdjustLightConfigurator";
            this.Size = new System.Drawing.Size(887, 596);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkColorTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox ddlBridge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel pnlLights;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TrackBar trkBrightness;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TrackBar trkColorTemperature;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TrackBar trkHue;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TrackBar trkSaturation;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
