namespace Kundenkartei
{
    partial class ShowCustomerNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCustomerNotes));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.customerTypeChoose = new MetroFramework.Controls.MetroComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.labKundenNr = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.richTextBoxToday = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.labGesamtSumme = new MetroFramework.Controls.MetroLabel();
            this.btnCloseWindow = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnSaveHistory = new MetroFramework.Controls.MetroButton();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.rtbChanges = new System.Windows.Forms.RichTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.labKNrTab2 = new MetroFramework.Controls.MetroLabel();
            this.labNameTab2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.b = new MetroFramework.Controls.MetroButton();
            this.btnSaveChanges = new MetroFramework.Controls.MetroButton();
            this.TabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.richTextBox1.Location = new System.Drawing.Point(10, 102);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(457, 210);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // customerTypeChoose
            // 
            this.customerTypeChoose.FormattingEnabled = true;
            this.customerTypeChoose.ItemHeight = 23;
            this.customerTypeChoose.Location = new System.Drawing.Point(556, 4);
            this.customerTypeChoose.Name = "customerTypeChoose";
            this.customerTypeChoose.Size = new System.Drawing.Size(432, 29);
            this.customerTypeChoose.TabIndex = 1;
            this.customerTypeChoose.UseSelectable = true;
            this.customerTypeChoose.SelectedValueChanged += new System.EventHandler(this.customerTypeChoose_SelectedValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(556, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 544);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(10, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Name:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labName.Location = new System.Drawing.Point(110, 8);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(58, 25);
            this.labName.TabIndex = 22;
            this.labName.Text = "Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(10, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 25);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "KundenNr:";
            // 
            // labKundenNr
            // 
            this.labKundenNr.AutoSize = true;
            this.labKundenNr.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labKundenNr.Location = new System.Drawing.Point(110, 38);
            this.labKundenNr.Name = "labKundenNr";
            this.labKundenNr.Size = new System.Drawing.Size(60, 25);
            this.labKundenNr.TabIndex = 24;
            this.labKundenNr.Text = "Kunde";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(199, 603);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(161, 45);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "Drucken";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(10, 603);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(168, 49);
            this.metroButton2.TabIndex = 26;
            this.metroButton2.Text = "Aktuellen Termin speichern";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // richTextBoxToday
            // 
            this.richTextBoxToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.richTextBoxToday.Location = new System.Drawing.Point(10, 391);
            this.richTextBoxToday.Name = "richTextBoxToday";
            this.richTextBoxToday.Size = new System.Drawing.Size(457, 201);
            this.richTextBoxToday.TabIndex = 27;
            this.richTextBoxToday.Text = "";
            this.richTextBoxToday.TextChanged += new System.EventHandler(this.richTextBoxToday_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(10, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(180, 25);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Historie aller Termine:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(10, 363);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(142, 25);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Aktueller Termin:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(319, 363);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 25);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Summe:";
            // 
            // labGesamtSumme
            // 
            this.labGesamtSumme.AutoSize = true;
            this.labGesamtSumme.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labGesamtSumme.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labGesamtSumme.Location = new System.Drawing.Point(402, 363);
            this.labGesamtSumme.Name = "labGesamtSumme";
            this.labGesamtSumme.Size = new System.Drawing.Size(0, 0);
            this.labGesamtSumme.TabIndex = 31;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.Location = new System.Drawing.Point(827, 603);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(161, 49);
            this.btnCloseWindow.TabIndex = 32;
            this.btnCloseWindow.Text = "Schließen";
            this.btnCloseWindow.UseSelectable = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(432, 391);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(35, 35);
            this.metroButton1.TabIndex = 33;
            this.metroButton1.Text = "X";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // btnSaveHistory
            // 
            this.btnSaveHistory.Location = new System.Drawing.Point(343, 310);
            this.btnSaveHistory.Name = "btnSaveHistory";
            this.btnSaveHistory.Size = new System.Drawing.Size(124, 39);
            this.btnSaveHistory.TabIndex = 34;
            this.btnSaveHistory.Text = "Historie aktualisieren";
            this.btnSaveHistory.UseSelectable = true;
            this.btnSaveHistory.Click += new System.EventHandler(this.btnSaveHistory_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.metroTabPage1);
            this.TabControl.Controls.Add(this.metroTabPage2);
            this.TabControl.Location = new System.Drawing.Point(9, 55);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 1;
            this.TabControl.Size = new System.Drawing.Size(1008, 690);
            this.TabControl.TabIndex = 36;
            this.TabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnPrint);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.labGesamtSumme);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.btnCloseWindow);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.richTextBoxToday);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.labKundenNr);
            this.metroTabPage1.Controls.Add(this.labName);
            this.metroTabPage1.Controls.Add(this.listBox1);
            this.metroTabPage1.Controls.Add(this.btnSaveHistory);
            this.metroTabPage1.Controls.Add(this.richTextBox1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.customerTypeChoose);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1000, 648);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Allgemein";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.b);
            this.metroTabPage2.Controls.Add(this.btnSaveChanges);
            this.metroTabPage2.Controls.Add(this.labKNrTab2);
            this.metroTabPage2.Controls.Add(this.labNameTab2);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.rtbChanges);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1000, 648);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Letzte Änderungen";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // rtbChanges
            // 
            this.rtbChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.rtbChanges.Location = new System.Drawing.Point(10, 105);
            this.rtbChanges.Name = "rtbChanges";
            this.rtbChanges.Size = new System.Drawing.Size(487, 481);
            this.rtbChanges.TabIndex = 29;
            this.rtbChanges.Text = "";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(10, 77);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(114, 25);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "Änderungen:";
            // 
            // labKNrTab2
            // 
            this.labKNrTab2.AutoSize = true;
            this.labKNrTab2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labKNrTab2.Location = new System.Drawing.Point(110, 39);
            this.labKNrTab2.Name = "labKNrTab2";
            this.labKNrTab2.Size = new System.Drawing.Size(60, 25);
            this.labKNrTab2.TabIndex = 34;
            this.labKNrTab2.Text = "Kunde";
            // 
            // labNameTab2
            // 
            this.labNameTab2.AutoSize = true;
            this.labNameTab2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labNameTab2.Location = new System.Drawing.Point(111, 8);
            this.labNameTab2.Name = "labNameTab2";
            this.labNameTab2.Size = new System.Drawing.Size(58, 25);
            this.labNameTab2.TabIndex = 32;
            this.labNameTab2.Text = "Name";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(10, 39);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(94, 25);
            this.metroLabel9.TabIndex = 33;
            this.metroLabel9.Text = "KundenNr:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(10, 8);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 25);
            this.metroLabel10.TabIndex = 31;
            this.metroLabel10.Text = "Name:";
            // 
            // b
            // 
            this.b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b.Location = new System.Drawing.Point(827, 603);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(161, 49);
            this.b.TabIndex = 36;
            this.b.Text = "Schließen";
            this.b.UseSelectable = true;
            this.b.Click += new System.EventHandler(this.B_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.Location = new System.Drawing.Point(10, 603);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(168, 49);
            this.btnSaveChanges.TabIndex = 35;
            this.btnSaveChanges.Text = "Änderungen speichern";
            this.btnSaveChanges.UseSelectable = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // ShowCustomerNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowCustomerNotes";
            this.Text = "Notizen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ShowCustomerNotes_Load);
            this.TabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroComboBox customerTypeChoose;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel labKundenNr;
        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.RichTextBox richTextBoxToday;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel labGesamtSumme;
        private MetroFramework.Controls.MetroButton btnCloseWindow;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnSaveHistory;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel labKNrTab2;
        private MetroFramework.Controls.MetroLabel labNameTab2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.RichTextBox rtbChanges;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton b;
        private MetroFramework.Controls.MetroButton btnSaveChanges;
    }
}