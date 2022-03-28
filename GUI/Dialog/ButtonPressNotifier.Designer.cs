namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Dialog
{
    partial class ButtonPressNotifier
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
            this.label1 = new System.Windows.Forms.Label();
            this.prgTimer = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press the button on the selected Philips Hue Bridge within 30 seconds...";
            // 
            // prgTimer
            // 
            this.prgTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgTimer.Location = new System.Drawing.Point(4, 46);
            this.prgTimer.Maximum = 30;
            this.prgTimer.Name = "prgTimer";
            this.prgTimer.Size = new System.Drawing.Size(429, 23);
            this.prgTimer.Step = 1;
            this.prgTimer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgTimer.TabIndex = 3;
            // 
            // ButtonPressNotifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 79);
            this.Controls.Add(this.prgTimer);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ButtonPressNotifier";
            this.Text = "ButtonPressNotifier";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.prgTimer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgTimer;
    }
}