namespace Kundenkartei
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateKunde = new MetroFramework.Controls.MetroButton();
            this.tbKundenName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClearSearch = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.TodayDatetime = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateKunde
            // 
            this.CreateKunde.Location = new System.Drawing.Point(9, 31);
            this.CreateKunde.Name = "CreateKunde";
            this.CreateKunde.Size = new System.Drawing.Size(161, 49);
            this.CreateKunde.TabIndex = 0;
            this.CreateKunde.Text = "Kunde anlegen";
            this.CreateKunde.UseSelectable = true;
            this.CreateKunde.Click += new System.EventHandler(this.CreateKunde_Click);
            // 
            // tbKundenName
            // 
            // 
            // 
            // 
            this.tbKundenName.CustomButton.Image = null;
            this.tbKundenName.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.tbKundenName.CustomButton.Name = "";
            this.tbKundenName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tbKundenName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbKundenName.CustomButton.TabIndex = 1;
            this.tbKundenName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbKundenName.CustomButton.UseSelectable = true;
            this.tbKundenName.CustomButton.Visible = false;
            this.tbKundenName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbKundenName.Lines = new string[0];
            this.tbKundenName.Location = new System.Drawing.Point(23, 269);
            this.tbKundenName.MaxLength = 32767;
            this.tbKundenName.Name = "tbKundenName";
            this.tbKundenName.PasswordChar = '\0';
            this.tbKundenName.PromptText = "Name suchen...";
            this.tbKundenName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKundenName.SelectedText = "";
            this.tbKundenName.SelectionLength = 0;
            this.tbKundenName.SelectionStart = 0;
            this.tbKundenName.ShortcutsEnabled = true;
            this.tbKundenName.Size = new System.Drawing.Size(171, 33);
            this.tbKundenName.TabIndex = 2;
            this.tbKundenName.UseSelectable = true;
            this.tbKundenName.WaterMark = "Name suchen...";
            this.tbKundenName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbKundenName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbKundenName.TextChanged += new System.EventHandler(this.tbKundenName_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Enabled = false;
            this.metroButton1.Location = new System.Drawing.Point(9, 86);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(161, 49);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Kunde bearbeiten";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(9, 86);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(161, 49);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Kunde löschen";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroListView1
            // 
            this.metroListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroListView1.CheckBoxes = true;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.metroListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.metroListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.metroListView1.Location = new System.Drawing.Point(23, 308);
            this.metroListView1.MultiSelect = false;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.Size = new System.Drawing.Size(940, 434);
            this.metroListView1.TabIndex = 7;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            this.metroListView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.metroListView1_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KundenNr";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Geburtstag";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dienstleistung";
            this.columnHeader5.Width = 262;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bei";
            this.columnHeader6.Width = 168;
            // 
            // ClearSearch
            // 
            this.ClearSearch.Location = new System.Drawing.Point(190, 269);
            this.ClearSearch.Name = "ClearSearch";
            this.ClearSearch.Size = new System.Drawing.Size(34, 33);
            this.ClearSearch.TabIndex = 8;
            this.ClearSearch.Text = "X";
            this.ClearSearch.UseSelectable = true;
            this.ClearSearch.Click += new System.EventHandler(this.ClearSearch_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton3.Location = new System.Drawing.Point(802, 63);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(161, 49);
            this.metroButton3.TabIndex = 11;
            this.metroButton3.Text = "Neuer Termin";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(9, 141);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(161, 49);
            this.metroButton4.TabIndex = 12;
            this.metroButton4.Text = "Kundeninformationen";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton5.Location = new System.Drawing.Point(802, 118);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(161, 48);
            this.metroButton5.TabIndex = 13;
            this.metroButton5.Text = "Termin bearbeiten";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // TodayDatetime
            // 
            this.TodayDatetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayDatetime.AutoSize = true;
            this.TodayDatetime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TodayDatetime.Location = new System.Drawing.Point(877, 25);
            this.TodayDatetime.Name = "TodayDatetime";
            this.TodayDatetime.Size = new System.Drawing.Size(86, 25);
            this.TodayDatetime.TabIndex = 14;
            this.TodayDatetime.Text = "01.01.2000";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(761, 287);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(99, 15);
            this.metroRadioButton1.TabIndex = 15;
            this.metroRadioButton1.Text = "Termine heute";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(877, 287);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(85, 15);
            this.metroRadioButton2.TabIndex = 16;
            this.metroRadioButton2.Text = "Kundenliste";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroButton6
            // 
            this.metroButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton6.Location = new System.Drawing.Point(176, 31);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(161, 49);
            this.metroButton6.TabIndex = 17;
            this.metroButton6.Text = "Notizen";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton6);
            this.groupBox1.Controls.Add(this.CreateKunde);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Location = new System.Drawing.Point(24, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 210);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunde";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 768);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.TodayDatetime);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.ClearSearch);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.tbKundenName);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Kundenverwaltung - Hairlight";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CreateKunde;
        private MetroFramework.Controls.MetroTextBox tbKundenName;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroButton ClearSearch;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroLabel TodayDatetime;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroButton metroButton6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

