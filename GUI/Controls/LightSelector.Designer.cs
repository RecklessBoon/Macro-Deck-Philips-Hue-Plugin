namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    partial class LightSelector
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
            this.btnControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnControl
            // 
            this.btnControl.AutoSize = true;
            this.btnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnControl.ForeColor = System.Drawing.Color.White;
            this.btnControl.Location = new System.Drawing.Point(5, 5);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(63, 35);
            this.btnControl.TabIndex = 0;
            this.btnControl.Text = "Light";
            this.btnControl.UseVisualStyleBackColor = true;
            // 
            // LightSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.btnControl);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "LightSelector";
            this.Size = new System.Drawing.Size(73, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnControl;
    }
}
