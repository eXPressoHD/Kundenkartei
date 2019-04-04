namespace Kundenkartei
{
    partial class Settings
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
            this.ckbxFullScreen = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // ckbxFullScreen
            // 
            this.ckbxFullScreen.AutoSize = true;
            this.ckbxFullScreen.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.ckbxFullScreen.Location = new System.Drawing.Point(42, 90);
            this.ckbxFullScreen.Name = "ckbxFullScreen";
            this.ckbxFullScreen.Size = new System.Drawing.Size(111, 19);
            this.ckbxFullScreen.TabIndex = 0;
            this.ckbxFullScreen.Text = "Vollbildmodus";
            this.ckbxFullScreen.UseSelectable = true;
            this.ckbxFullScreen.CheckedChanged += new System.EventHandler(this.ckbxFullScreen_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.ckbxFullScreen);
            this.Name = "Settings";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox ckbxFullScreen;
    }
}