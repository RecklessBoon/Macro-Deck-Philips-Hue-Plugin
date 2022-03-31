namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    partial class UpdateLightConfigurator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lightSettings1 = new RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls.Custom.LightSettings();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLights = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlBridge = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lightSettings1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlLights);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddlBridge);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 381);
            this.panel1.TabIndex = 0;
            // 
            // lightSettings1
            // 
            this.lightSettings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lightSettings1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lightSettings1.ForeColor = System.Drawing.Color.White;
            this.lightSettings1.Location = new System.Drawing.Point(95, 200);
            this.lightSettings1.Margin = new System.Windows.Forms.Padding(5);
            this.lightSettings1.Name = "lightSettings1";
            this.lightSettings1.Size = new System.Drawing.Size(751, 147);
            this.lightSettings1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Settings:";
            // 
            // pnlLights
            // 
            this.pnlLights.Location = new System.Drawing.Point(95, 36);
            this.pnlLights.Name = "pnlLights";
            this.pnlLights.Size = new System.Drawing.Size(753, 156);
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
            this.ddlBridge.Location = new System.Drawing.Point(95, 4);
            this.ddlBridge.Name = "ddlBridge";
            this.ddlBridge.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.ddlBridge.SelectedIndex = -1;
            this.ddlBridge.SelectedItem = null;
            this.ddlBridge.Size = new System.Drawing.Size(753, 26);
            this.ddlBridge.TabIndex = 1;
            // 
            // UpdateLightConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UpdateLightConfigurator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox ddlBridge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel pnlLights;
        private System.Windows.Forms.Label label2;
        private Custom.LightSettings lightSettings1;
    }
}
