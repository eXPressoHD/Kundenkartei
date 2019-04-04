namespace Kundenkartei
{
    partial class CustomerHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHistory));
            this.metroListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.tbMail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbStadt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbPlz = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbAdresse = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbTelefon = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbKundenNr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGeburtstag = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.CheckBoxes = true;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.metroListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.metroListView1.Location = new System.Drawing.Point(0, 30);
            this.metroListView1.MultiSelect = false;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.Size = new System.Drawing.Size(947, 385);
            this.metroListView1.TabIndex = 8;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.View = System.Windows.Forms.View.Details;
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Termin";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dienstleistung";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bei";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(800, 360);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(141, 49);
            this.metroButton3.TabIndex = 19;
            this.metroButton3.Text = "Termin Bearbeiten";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // tbMail
            // 
            // 
            // 
            // 
            this.tbMail.CustomButton.Image = null;
            this.tbMail.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.tbMail.CustomButton.Name = "";
            this.tbMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMail.CustomButton.TabIndex = 1;
            this.tbMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMail.CustomButton.UseSelectable = true;
            this.tbMail.CustomButton.Visible = false;
            this.tbMail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMail.Lines = new string[0];
            this.tbMail.Location = new System.Drawing.Point(495, 169);
            this.tbMail.MaxLength = 32767;
            this.tbMail.Name = "tbMail";
            this.tbMail.PasswordChar = '\0';
            this.tbMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMail.SelectedText = "";
            this.tbMail.SelectionLength = 0;
            this.tbMail.SelectionStart = 0;
            this.tbMail.ShortcutsEnabled = true;
            this.tbMail.Size = new System.Drawing.Size(224, 23);
            this.tbMail.TabIndex = 24;
            this.tbMail.UseSelectable = true;
            this.tbMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(420, 169);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 25);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Email:";
            // 
            // tbStadt
            // 
            // 
            // 
            // 
            this.tbStadt.CustomButton.Image = null;
            this.tbStadt.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.tbStadt.CustomButton.Name = "";
            this.tbStadt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbStadt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStadt.CustomButton.TabIndex = 1;
            this.tbStadt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStadt.CustomButton.UseSelectable = true;
            this.tbStadt.CustomButton.Visible = false;
            this.tbStadt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbStadt.Lines = new string[0];
            this.tbStadt.Location = new System.Drawing.Point(495, 132);
            this.tbStadt.MaxLength = 32767;
            this.tbStadt.Name = "tbStadt";
            this.tbStadt.PasswordChar = '\0';
            this.tbStadt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStadt.SelectedText = "";
            this.tbStadt.SelectionLength = 0;
            this.tbStadt.SelectionStart = 0;
            this.tbStadt.ShortcutsEnabled = true;
            this.tbStadt.Size = new System.Drawing.Size(224, 23);
            this.tbStadt.TabIndex = 22;
            this.tbStadt.UseSelectable = true;
            this.tbStadt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStadt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(420, 130);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 25);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Stadt:";
            // 
            // tbPlz
            // 
            // 
            // 
            // 
            this.tbPlz.CustomButton.Image = null;
            this.tbPlz.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.tbPlz.CustomButton.Name = "";
            this.tbPlz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPlz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPlz.CustomButton.TabIndex = 1;
            this.tbPlz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPlz.CustomButton.UseSelectable = true;
            this.tbPlz.CustomButton.Visible = false;
            this.tbPlz.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbPlz.Lines = new string[0];
            this.tbPlz.Location = new System.Drawing.Point(495, 94);
            this.tbPlz.MaxLength = 32767;
            this.tbPlz.Name = "tbPlz";
            this.tbPlz.PasswordChar = '\0';
            this.tbPlz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPlz.SelectedText = "";
            this.tbPlz.SelectionLength = 0;
            this.tbPlz.SelectionStart = 0;
            this.tbPlz.ShortcutsEnabled = true;
            this.tbPlz.Size = new System.Drawing.Size(115, 23);
            this.tbPlz.TabIndex = 21;
            this.tbPlz.UseSelectable = true;
            this.tbPlz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPlz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(420, 92);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 25);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "PLZ:";
            // 
            // tbAdresse
            // 
            // 
            // 
            // 
            this.tbAdresse.CustomButton.Image = null;
            this.tbAdresse.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.tbAdresse.CustomButton.Name = "";
            this.tbAdresse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAdresse.CustomButton.TabIndex = 1;
            this.tbAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAdresse.CustomButton.UseSelectable = true;
            this.tbAdresse.CustomButton.Visible = false;
            this.tbAdresse.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbAdresse.Lines = new string[0];
            this.tbAdresse.Location = new System.Drawing.Point(495, 56);
            this.tbAdresse.MaxLength = 32767;
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.PasswordChar = '\0';
            this.tbAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAdresse.SelectedText = "";
            this.tbAdresse.SelectionLength = 0;
            this.tbAdresse.SelectionStart = 0;
            this.tbAdresse.ShortcutsEnabled = true;
            this.tbAdresse.Size = new System.Drawing.Size(224, 23);
            this.tbAdresse.TabIndex = 20;
            this.tbAdresse.UseSelectable = true;
            this.tbAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAdresse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(420, 54);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 25);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Straße:";
            // 
            // tbTelefon
            // 
            // 
            // 
            // 
            this.tbTelefon.CustomButton.Image = null;
            this.tbTelefon.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tbTelefon.CustomButton.Name = "";
            this.tbTelefon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTelefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTelefon.CustomButton.TabIndex = 1;
            this.tbTelefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTelefon.CustomButton.UseSelectable = true;
            this.tbTelefon.CustomButton.Visible = false;
            this.tbTelefon.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbTelefon.Lines = new string[0];
            this.tbTelefon.Location = new System.Drawing.Point(181, 132);
            this.tbTelefon.MaxLength = 32767;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.PasswordChar = '\0';
            this.tbTelefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTelefon.SelectedText = "";
            this.tbTelefon.SelectionLength = 0;
            this.tbTelefon.SelectionStart = 0;
            this.tbTelefon.ShortcutsEnabled = true;
            this.tbTelefon.Size = new System.Drawing.Size(164, 23);
            this.tbTelefon.TabIndex = 30;
            this.tbTelefon.UseSelectable = true;
            this.tbTelefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTelefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(81, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 25);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Telefon:";
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(181, 94);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(164, 23);
            this.tbName.TabIndex = 29;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(81, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 25);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Name:";
            // 
            // tbKundenNr
            // 
            // 
            // 
            // 
            this.tbKundenNr.CustomButton.Image = null;
            this.tbKundenNr.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tbKundenNr.CustomButton.Name = "";
            this.tbKundenNr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbKundenNr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbKundenNr.CustomButton.TabIndex = 1;
            this.tbKundenNr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbKundenNr.CustomButton.UseSelectable = true;
            this.tbKundenNr.CustomButton.Visible = false;
            this.tbKundenNr.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbKundenNr.Lines = new string[0];
            this.tbKundenNr.Location = new System.Drawing.Point(181, 56);
            this.tbKundenNr.MaxLength = 32767;
            this.tbKundenNr.Name = "tbKundenNr";
            this.tbKundenNr.PasswordChar = '\0';
            this.tbKundenNr.ReadOnly = true;
            this.tbKundenNr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKundenNr.SelectedText = "";
            this.tbKundenNr.SelectionLength = 0;
            this.tbKundenNr.SelectionStart = 0;
            this.tbKundenNr.ShortcutsEnabled = true;
            this.tbKundenNr.Size = new System.Drawing.Size(164, 23);
            this.tbKundenNr.TabIndex = 28;
            this.tbKundenNr.UseSelectable = true;
            this.tbKundenNr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbKundenNr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(81, 54);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 25);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "KundenNr:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(708, 302);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(141, 49);
            this.metroButton1.TabIndex = 34;
            this.metroButton1.Text = "Informationen speichern";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGeburtstag);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.tbTelefon);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbMail);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.tbAdresse);
            this.groupBox1.Controls.Add(this.tbKundenNr);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.tbPlz);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.tbStadt);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 233);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunde bearbeiten";
            // 
            // tbGeburtstag
            // 
            // 
            // 
            // 
            this.tbGeburtstag.CustomButton.Image = null;
            this.tbGeburtstag.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tbGeburtstag.CustomButton.Name = "";
            this.tbGeburtstag.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbGeburtstag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbGeburtstag.CustomButton.TabIndex = 1;
            this.tbGeburtstag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbGeburtstag.CustomButton.UseSelectable = true;
            this.tbGeburtstag.CustomButton.Visible = false;
            this.tbGeburtstag.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbGeburtstag.Lines = new string[0];
            this.tbGeburtstag.Location = new System.Drawing.Point(181, 171);
            this.tbGeburtstag.MaxLength = 32767;
            this.tbGeburtstag.Name = "tbGeburtstag";
            this.tbGeburtstag.PasswordChar = '\0';
            this.tbGeburtstag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbGeburtstag.SelectedText = "";
            this.tbGeburtstag.SelectionLength = 0;
            this.tbGeburtstag.SelectionStart = 0;
            this.tbGeburtstag.ShortcutsEnabled = true;
            this.tbGeburtstag.Size = new System.Drawing.Size(164, 23);
            this.tbGeburtstag.TabIndex = 35;
            this.tbGeburtstag.UseSelectable = true;
            this.tbGeburtstag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbGeburtstag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(81, 169);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(100, 25);
            this.metroLabel8.TabIndex = 36;
            this.metroLabel8.Text = "Geburtstag:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton3);
            this.groupBox2.Controls.Add(this.metroListView1);
            this.groupBox2.Location = new System.Drawing.Point(23, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 415);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Termine";
            this.groupBox2.Visible = false;
            // 
            // CustomerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerHistory";
            this.Text = "Kundeninformationen";
            this.Activated += new System.EventHandler(this.CustomerHistory_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox tbMail;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbStadt;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbPlz;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbAdresse;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbTelefon;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbKundenNr;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox tbGeburtstag;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}