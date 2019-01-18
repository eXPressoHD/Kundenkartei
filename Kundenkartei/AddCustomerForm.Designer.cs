namespace Kundenkartei
{
    partial class AddCustomerForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.tbTelefon = new MetroFramework.Controls.MetroTextBox();
            this.Kunde_anlegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(55, 166);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Telefonnummer:";
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(225, 130);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(171, 23);
            this.tbName.TabIndex = 2;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbTelefon
            // 
            // 
            // 
            // 
            this.tbTelefon.CustomButton.Image = null;
            this.tbTelefon.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.tbTelefon.CustomButton.Name = "";
            this.tbTelefon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTelefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTelefon.CustomButton.TabIndex = 1;
            this.tbTelefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTelefon.CustomButton.UseSelectable = true;
            this.tbTelefon.CustomButton.Visible = false;
            this.tbTelefon.Lines = new string[0];
            this.tbTelefon.Location = new System.Drawing.Point(225, 166);
            this.tbTelefon.MaxLength = 32767;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.PasswordChar = '\0';
            this.tbTelefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTelefon.SelectedText = "";
            this.tbTelefon.SelectionLength = 0;
            this.tbTelefon.SelectionStart = 0;
            this.tbTelefon.ShortcutsEnabled = true;
            this.tbTelefon.Size = new System.Drawing.Size(171, 23);
            this.tbTelefon.TabIndex = 3;
            this.tbTelefon.UseSelectable = true;
            this.tbTelefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTelefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Kunde_anlegen
            // 
            this.Kunde_anlegen.Location = new System.Drawing.Point(55, 241);
            this.Kunde_anlegen.Name = "Kunde_anlegen";
            this.Kunde_anlegen.Size = new System.Drawing.Size(104, 23);
            this.Kunde_anlegen.TabIndex = 4;
            this.Kunde_anlegen.Text = "Kunde hinzufügen";
            this.Kunde_anlegen.UseVisualStyleBackColor = true;
            this.Kunde_anlegen.Click += new System.EventHandler(this.Kunde_anlegen_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 316);
            this.Controls.Add(this.Kunde_anlegen);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddCustomerForm";
            this.Text = "Kunde hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroTextBox tbTelefon;
        private System.Windows.Forms.Button Kunde_anlegen;
    }
}