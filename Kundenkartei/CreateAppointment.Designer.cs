namespace Kundenkartei
{
    partial class CreateAppointment
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.ClearSearch = new MetroFramework.Controls.MetroButton();
            this.CustomerList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbKundenName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbMitarbeiter = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(37, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Datum:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(37, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Dienstleistung:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(169, 127);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(285, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ClearSearch
            // 
            this.ClearSearch.Location = new System.Drawing.Point(179, 241);
            this.ClearSearch.Name = "ClearSearch";
            this.ClearSearch.Size = new System.Drawing.Size(34, 33);
            this.ClearSearch.TabIndex = 17;
            this.ClearSearch.Text = "X";
            this.ClearSearch.UseSelectable = true;
            this.ClearSearch.Click += new System.EventHandler(this.ClearSearch_Click);
            // 
            // CustomerList
            // 
            this.CustomerList.CheckBoxes = true;
            this.CustomerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.CustomerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CustomerList.Location = new System.Drawing.Point(34, 280);
            this.CustomerList.MultiSelect = false;
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(582, 261);
            this.CustomerList.TabIndex = 16;
            this.CustomerList.UseCompatibleStateImageBehavior = false;
            this.CustomerList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KundenNr";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 150;
            // 
            // tbKundenName
            // 
            // 
            // 
            // 
            this.tbKundenName.CustomButton.Image = null;
            this.tbKundenName.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.tbKundenName.CustomButton.Name = "";
            this.tbKundenName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tbKundenName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbKundenName.CustomButton.TabIndex = 1;
            this.tbKundenName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbKundenName.CustomButton.UseSelectable = true;
            this.tbKundenName.CustomButton.Visible = false;
            this.tbKundenName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbKundenName.Lines = new string[0];
            this.tbKundenName.Location = new System.Drawing.Point(34, 241);
            this.tbKundenName.MaxLength = 32767;
            this.tbKundenName.Name = "tbKundenName";
            this.tbKundenName.PasswordChar = '\0';
            this.tbKundenName.PromptText = "Name suchen...";
            this.tbKundenName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKundenName.SelectedText = "";
            this.tbKundenName.SelectionLength = 0;
            this.tbKundenName.SelectionStart = 0;
            this.tbKundenName.ShortcutsEnabled = true;
            this.tbKundenName.Size = new System.Drawing.Size(150, 33);
            this.tbKundenName.TabIndex = 15;
            this.tbKundenName.UseSelectable = true;
            this.tbKundenName.WaterMark = "Name suchen...";
            this.tbKundenName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbKundenName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbKundenName.TextChanged += new System.EventHandler(this.tbKundenName_TextChanged);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(34, 559);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(135, 45);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Termin erstellen";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(460, 85);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(69, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(37, 167);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 25);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Bei:";
            // 
            // tbMitarbeiter
            // 
            // 
            // 
            // 
            this.tbMitarbeiter.CustomButton.Image = null;
            this.tbMitarbeiter.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.tbMitarbeiter.CustomButton.Name = "";
            this.tbMitarbeiter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMitarbeiter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMitarbeiter.CustomButton.TabIndex = 1;
            this.tbMitarbeiter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMitarbeiter.CustomButton.UseSelectable = true;
            this.tbMitarbeiter.CustomButton.Visible = false;
            this.tbMitarbeiter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMitarbeiter.Lines = new string[0];
            this.tbMitarbeiter.Location = new System.Drawing.Point(169, 169);
            this.tbMitarbeiter.MaxLength = 32767;
            this.tbMitarbeiter.Name = "tbMitarbeiter";
            this.tbMitarbeiter.PasswordChar = '\0';
            this.tbMitarbeiter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMitarbeiter.SelectedText = "";
            this.tbMitarbeiter.SelectionLength = 0;
            this.tbMitarbeiter.SelectionStart = 0;
            this.tbMitarbeiter.ShortcutsEnabled = true;
            this.tbMitarbeiter.Size = new System.Drawing.Size(131, 23);
            this.tbMitarbeiter.TabIndex = 4;
            this.tbMitarbeiter.UseSelectable = true;
            this.tbMitarbeiter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMitarbeiter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(473, 241);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(143, 33);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "Alle Kunden anzeigen";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 627);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tbMitarbeiter);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.ClearSearch);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.tbKundenName);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CreateAppointment";
            this.Text = "Neuen Termin anlegen";
            this.Activated += new System.EventHandler(this.CreateAppointment_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton ClearSearch;
        private System.Windows.Forms.ListView CustomerList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroTextBox tbKundenName;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbMitarbeiter;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}