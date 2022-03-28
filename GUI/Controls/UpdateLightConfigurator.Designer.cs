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
            this.btnColorSelector = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOnOff = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlBridge = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlLights = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pnlLights);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnColorSelector);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxOnOff);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddlBridge);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 381);
            this.panel1.TabIndex = 0;
            // 
            // btnColorSelector
            // 
            this.btnColorSelector.BackColor = System.Drawing.Color.White;
            this.btnColorSelector.Location = new System.Drawing.Point(80, 224);
            this.btnColorSelector.Name = "btnColorSelector";
            this.btnColorSelector.Size = new System.Drawing.Size(182, 23);
            this.btnColorSelector.TabIndex = 6;
            this.btnColorSelector.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "On/Off:";
            // 
            // cbxOnOff
            // 
            this.cbxOnOff.AutoSize = true;
            this.cbxOnOff.Location = new System.Drawing.Point(84, 198);
            this.cbxOnOff.Name = "cbxOnOff";
            this.cbxOnOff.Size = new System.Drawing.Size(15, 14);
            this.cbxOnOff.TabIndex = 3;
            this.cbxOnOff.UseVisualStyleBackColor = true;
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
            this.ddlBridge.Location = new System.Drawing.Point(80, 4);
            this.ddlBridge.Name = "ddlBridge";
            this.ddlBridge.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.ddlBridge.SelectedIndex = -1;
            this.ddlBridge.SelectedItem = null;
            this.ddlBridge.Size = new System.Drawing.Size(768, 26);
            this.ddlBridge.TabIndex = 1;
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
            // pnlLights
            // 
            this.pnlLights.Location = new System.Drawing.Point(84, 36);
            this.pnlLights.Name = "pnlLights";
            this.pnlLights.Size = new System.Drawing.Size(764, 156);
            this.pnlLights.TabIndex = 9;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxOnOff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel pnlLights;
    }
}
