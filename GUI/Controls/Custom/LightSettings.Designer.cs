namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls.Custom
{
    partial class LightSettings
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
            this.btnColorSelector = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOnOff = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.trkBrightness = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.numTransitionTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransitionTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColorSelector
            // 
            this.btnColorSelector.BackColor = System.Drawing.Color.White;
            this.btnColorSelector.Location = new System.Drawing.Point(153, 26);
            this.btnColorSelector.Name = "btnColorSelector";
            this.btnColorSelector.Size = new System.Drawing.Size(182, 23);
            this.btnColorSelector.TabIndex = 10;
            this.btnColorSelector.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "On/Off:";
            // 
            // cbxOnOff
            // 
            this.cbxOnOff.AutoSize = true;
            this.cbxOnOff.Location = new System.Drawing.Point(153, 6);
            this.cbxOnOff.Name = "cbxOnOff";
            this.cbxOnOff.Size = new System.Drawing.Size(15, 14);
            this.cbxOnOff.TabIndex = 7;
            this.cbxOnOff.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Brightness:";
            // 
            // trkBrightness
            // 
            this.trkBrightness.LargeChange = 15;
            this.trkBrightness.Location = new System.Drawing.Point(153, 55);
            this.trkBrightness.Maximum = 255;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Size = new System.Drawing.Size(462, 45);
            this.trkBrightness.TabIndex = 12;
            this.trkBrightness.TickFrequency = 15;
            this.trkBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Transition Time:";
            // 
            // numTransitionTime
            // 
            this.numTransitionTime.Location = new System.Drawing.Point(153, 106);
            this.numTransitionTime.Maximum = new decimal(new int[] {
            655,
            0,
            0,
            0});
            this.numTransitionTime.Name = "numTransitionTime";
            this.numTransitionTime.Size = new System.Drawing.Size(120, 33);
            this.numTransitionTime.TabIndex = 14;
            this.numTransitionTime.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "x 100ms";
            // 
            // LightSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTransitionTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trkBrightness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColorSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxOnOff);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LightSettings";
            this.Size = new System.Drawing.Size(698, 152);
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransitionTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnColorSelector;
        public System.Windows.Forms.CheckBox cbxOnOff;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar trkBrightness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown numTransitionTime;
    }
}
