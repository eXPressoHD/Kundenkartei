﻿namespace Kundenkartei
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
            this.metroCheckBoxTermineHeute = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CreateKunde
            // 
            this.CreateKunde.Location = new System.Drawing.Point(23, 63);
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
            this.tbKundenName.Location = new System.Drawing.Point(23, 250);
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
            this.metroButton1.Location = new System.Drawing.Point(23, 118);
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
            this.metroButton2.Location = new System.Drawing.Point(23, 118);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(161, 49);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Kunde löschen";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
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
            this.metroListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.metroListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.metroListView1.Location = new System.Drawing.Point(23, 289);
            this.metroListView1.MultiSelect = false;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.Size = new System.Drawing.Size(940, 453);
            this.metroListView1.TabIndex = 7;
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
            this.columnHeader5.Width = 262;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bei";
            this.columnHeader6.Width = 168;
            // 
            // ClearSearch
            // 
            this.ClearSearch.Location = new System.Drawing.Point(190, 250);
            this.ClearSearch.Name = "ClearSearch";
            this.ClearSearch.Size = new System.Drawing.Size(34, 33);
            this.ClearSearch.TabIndex = 8;
            this.ClearSearch.Text = "X";
            this.ClearSearch.UseSelectable = true;
            this.ClearSearch.Click += new System.EventHandler(this.ClearSearch_Click);
            // 
            // metroCheckBoxTermineHeute
            // 
            this.metroCheckBoxTermineHeute.AutoSize = true;
            this.metroCheckBoxTermineHeute.Location = new System.Drawing.Point(864, 268);
            this.metroCheckBoxTermineHeute.Name = "metroCheckBoxTermineHeute";
            this.metroCheckBoxTermineHeute.Size = new System.Drawing.Size(99, 15);
            this.metroCheckBoxTermineHeute.TabIndex = 9;
            this.metroCheckBoxTermineHeute.Text = "Termine heute";
            this.metroCheckBoxTermineHeute.UseSelectable = true;
            this.metroCheckBoxTermineHeute.CheckedChanged += new System.EventHandler(this.metroCheckBoxTermineHeute_CheckedChanged);
            // 
            // metroButton3
            // 
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
            this.metroButton4.Location = new System.Drawing.Point(23, 173);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(161, 49);
            this.metroButton4.TabIndex = 12;
            this.metroButton4.Text = "Kundeninformationen";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(802, 118);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(161, 48);
            this.metroButton5.TabIndex = 13;
            this.metroButton5.Text = "Termin bearbeiten";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 768);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroCheckBoxTermineHeute);
            this.Controls.Add(this.ClearSearch);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tbKundenName);
            this.Controls.Add(this.CreateKunde);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Kundenverwaltung - Hairlight";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
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
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxTermineHeute;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}

