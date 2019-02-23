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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.customerTypeChoose = new MetroFramework.Controls.MetroComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.labKundenNr = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.richTextBox1.Location = new System.Drawing.Point(23, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(457, 528);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // customerTypeChoose
            // 
            this.customerTypeChoose.FormattingEnabled = true;
            this.customerTypeChoose.ItemHeight = 23;
            this.customerTypeChoose.Location = new System.Drawing.Point(677, 57);
            this.customerTypeChoose.Name = "customerTypeChoose";
            this.customerTypeChoose.Size = new System.Drawing.Size(324, 29);
            this.customerTypeChoose.TabIndex = 1;
            this.customerTypeChoose.UseSelectable = true;
            this.customerTypeChoose.SelectedValueChanged += new System.EventHandler(this.customerTypeChoose_SelectedValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(677, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 584);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton6.Location = new System.Drawing.Point(23, 696);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(161, 49);
            this.metroButton6.TabIndex = 18;
            this.metroButton6.Text = "Änderungen speichern";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(500, 165);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(161, 49);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Termin anhängen";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            // ShowCustomerNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.labKundenNr);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton6);
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
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel labKundenNr;
    }
}