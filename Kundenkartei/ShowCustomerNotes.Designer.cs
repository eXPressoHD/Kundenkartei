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
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.richTextBox1.Location = new System.Drawing.Point(23, 170);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(457, 263);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // customerTypeChoose
            // 
            this.customerTypeChoose.FormattingEnabled = true;
            this.customerTypeChoose.ItemHeight = 23;
            this.customerTypeChoose.Location = new System.Drawing.Point(569, 57);
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
            this.listBox1.Location = new System.Drawing.Point(569, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 584);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Name:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labName.Location = new System.Drawing.Point(123, 70);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(0, 0);
            this.labName.TabIndex = 22;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 25);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "KundenNr:";
            // 
            // labKundenNr
            // 
            this.labKundenNr.AutoSize = true;
            this.labKundenNr.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labKundenNr.Location = new System.Drawing.Point(123, 105);
            this.labKundenNr.Name = "labKundenNr";
            this.labKundenNr.Size = new System.Drawing.Size(0, 0);
            this.labKundenNr.TabIndex = 24;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(840, 696);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(161, 49);
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
            this.metroButton2.Location = new System.Drawing.Point(23, 696);
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
            this.richTextBoxToday.Location = new System.Drawing.Point(23, 475);
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
            this.metroLabel2.Location = new System.Drawing.Point(23, 142);
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
            this.metroLabel4.Location = new System.Drawing.Point(23, 447);
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
            this.metroLabel5.Location = new System.Drawing.Point(332, 447);
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
            this.labGesamtSumme.Location = new System.Drawing.Point(415, 447);
            this.labGesamtSumme.Name = "labGesamtSumme";
            this.labGesamtSumme.Size = new System.Drawing.Size(0, 0);
            this.labGesamtSumme.TabIndex = 31;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.Location = new System.Drawing.Point(840, 696);
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
            this.metroButton1.Location = new System.Drawing.Point(445, 475);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(35, 35);
            this.metroButton1.TabIndex = 33;
            this.metroButton1.Text = "X";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // ShowCustomerNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.labGesamtSumme);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.richTextBoxToday);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labKundenNr);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.customerTypeChoose);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ShowCustomerNotes";
            this.Text = "Notizen";
            this.Load += new System.EventHandler(this.ShowCustomerNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}