namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    partial class SetSceneConfigurator
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
            this.ddlRoom = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlScene = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.ddlRoom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ddlScene);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddlBridge);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 106);
            this.panel1.TabIndex = 2;
            // 
            // ddlRoom
            // 
            this.ddlRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ddlRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRoom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddlRoom.Icon = null;
            this.ddlRoom.Location = new System.Drawing.Point(80, 67);
            this.ddlRoom.Name = "ddlRoom";
            this.ddlRoom.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.ddlRoom.SelectedIndex = -1;
            this.ddlRoom.SelectedItem = null;
            this.ddlRoom.Size = new System.Drawing.Size(768, 26);
            this.ddlRoom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room:";
            // 
            // ddlScene
            // 
            this.ddlScene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ddlScene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlScene.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddlScene.Icon = null;
            this.ddlScene.Location = new System.Drawing.Point(80, 35);
            this.ddlScene.Name = "ddlScene";
            this.ddlScene.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.ddlScene.SelectedIndex = -1;
            this.ddlScene.SelectedItem = null;
            this.ddlScene.Size = new System.Drawing.Size(768, 26);
            this.ddlScene.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scene:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
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
            this.ddlBridge.Location = new System.Drawing.Point(80, 3);
            this.ddlBridge.Name = "ddlBridge";
            this.ddlBridge.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.ddlBridge.SelectedIndex = -1;
            this.ddlBridge.SelectedItem = null;
            this.ddlBridge.Size = new System.Drawing.Size(768, 26);
            this.ddlBridge.TabIndex = 1;
            // 
            // ActivateSceneConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ActivateSceneConfigurator";
            this.Size = new System.Drawing.Size(857, 149);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox ddlBridge;
        private System.Windows.Forms.Label label2;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox ddlScene;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox ddlRoom;
        private System.Windows.Forms.Label label3;
    }
}
