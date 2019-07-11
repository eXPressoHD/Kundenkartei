using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kundenkartei
{
    public partial class ShowCustomerNotes : MetroFramework.Forms.MetroForm
    {
        List<String> preisOnly = new List<string>();
        private int _sum = 0;
        private int _counter = 0;
        private List<String> invoiceStrings = new List<string>();
        private string _printText;
        private int _gesamtSumme;

        public ShowCustomerNotes()
        {
            InitializeComponent();
            FetchTypes();
        }

        private void FetchTypes()
        {
            List<String> types = new List<string>();
            DataTable tab = SqliteDataAccess.GetCustomerTypes();
            foreach (DataRow row in tab.Rows)
            {
                types.Add(row["Typ"].ToString());
            }

            customerTypeChoose.Items.AddRange(types.ToArray());
        }

        private void customerTypeChoose_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MetroFramework.Controls.MetroComboBox box = sender as MetroComboBox;
            DataTable preisTab = new DataTable();
            List<String> preisListe = new List<string>();

            if (box.Text == "Herren")
            {
                preisTab = SqliteDataAccess.GetPriceList("Herren");
            } else if (box.Text == "Damen")
            {
                preisTab = SqliteDataAccess.GetPriceList("Damen");
            } else if (box.Text == "Kids")
            {
                preisTab = SqliteDataAccess.GetPriceList("Kids");
            }

            foreach (DataRow row in preisTab.Rows)
            {
                preisListe.Add(String.Format("{0} - {1}", row["Titel"].ToString(), row["Preis"].ToString() + "€"));
            }

            listBox1.Items.AddRange(preisListe.ToArray());
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            invoiceStrings.Add(richTextBoxToday.Text);
            _counter++;
            richTextBoxToday.Text += text;
            richTextBoxToday.Text += Environment.NewLine;
            _gesamtSumme += Convert.ToInt32(Regex.Match(listBox1.GetItemText(listBox1.SelectedItem), @"\d+").Value);
            labGesamtSumme.Text = _sum.ToString() + "€";
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

        }

        private void ShowCustomerNotes_Load(object sender, EventArgs e)
        {
            TabControl.SelectedTab = metroTabPage1;
            int id = (int)this.Tag;
            DataTable kunde = SqliteDataAccess.GetKundeById(id);
            Kunde k = new Kunde(Convert.ToInt32(id), kunde.Rows[0].ItemArray[1].ToString(), kunde.Rows[0].ItemArray[2].ToString());
            labName.Text = k.Name;
            labNameTab2.Text = k.Name;
            labKNrTab2.Text = id.ToString();
            labKundenNr.Text = id.ToString();
            FetchNotes();
            customerTypeChoose.Text = "Damen";
        }

        private void FetchNotes()
        {
            int nr = (int)this.Tag;
            DataTable notes = SqliteDataAccess.GetKundenNotes(nr);
            DataTable changes = SqliteDataAccess.GetKundenChanges(nr);
            string text = notes.Rows[0].ItemArray[0].ToString();
            string changesText = changes.Rows[0].ItemArray[0].ToString();
            richTextBox1.Text = text;
            rtbChanges.Text = changesText;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += DateTime.Now.ToString("dd.MM.yyyy");
            richTextBox1.Text += Environment.NewLine;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Bitmap bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.Document = printDocument1;
            //  printPreviewDialog1.Show();

            try {
                printDocument1.Print();
            } catch (InvalidPrinterException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(_printText, new Font("Arial", Convert.ToInt32(ConfigurationManager.AppSettings["PrintFontSize"]), FontStyle.Regular), Brushes.Black, 150, 125);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (_sum > 0)
            {
                StringBuilder sb = new StringBuilder();
                string shopAdress = "Friseur Hairlight";
                _printText = shopAdress + Environment.NewLine + "Termin am: " + DateTime.Now.ToString("dd.MM.yyyy") + Environment.NewLine + richTextBoxToday.Text + Environment.NewLine + "Gesamtsumme: " + _sum.ToString() + "€";
                richTextBox1.Text += Environment.NewLine;
                richTextBox1.Text += Environment.NewLine;
                richTextBox1.Text += DateTime.Now.ToString("dd.MM.yyyy");
                richTextBox1.Text += Environment.NewLine;
                richTextBox1.Text += richTextBoxToday.Text;
                richTextBox1.Text += "Gesamtsumme: " + _sum.ToString() + "€";

                richTextBoxToday.Clear();
                _counter = 0;
                _sum = 0;
                labGesamtSumme.Text = String.Empty;
                int kundenNr = (int)this.Tag;
                DataTable kunde = SqliteDataAccess.GetKundeById(kundenNr);
                Kunde k = new Kunde(Convert.ToInt32(kundenNr), kunde.Rows[0]["Name"].ToString(), kunde.Rows[0]["Telefon"].ToString(), kunde.Rows[0]["Geburtstag"].ToString(), kunde.Rows[0]["Strasse"].ToString(), kunde.Rows[0]["PLZ"].ToString(), kunde.Rows[0]["Stadt"].ToString(), kunde.Rows[0]["Email"].ToString(), kunde.Rows[0]["Notizen"].ToString());
                k.Notizen = richTextBox1.Text;
                SqliteDataAccess.UpdateKunde(k);

                if (ConfigurationManager.AppSettings["AskForPrint"].ToString() == "true")
                {
                    DialogResult dialogResult = MessageBox.Show("Beleg drucken?", "Drucken", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        btnPrint_Click(sender, e);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                } else
                {

                }
            }
        }
        

        private void richTextBoxToday_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBoxToday.Text))
            {
                _sum = 0;
                string test = String.Empty;

                for (int i = 0; i < richTextBoxToday.Lines.Length; i++)
                {
                    if (richTextBoxToday.Lines[i].Any(char.IsDigit))
                    {
                        _sum += Convert.ToInt32(Regex.Match(richTextBoxToday.Lines[i], @"\d+").Value);
                    }
                }
                labGesamtSumme.Text = _sum.ToString() + "€";
            } else
            {

            }
        }



        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            /*
            if (_counter  > 0)
            {                
                richTextBoxToday.SelectionStart = richTextBoxToday.GetFirstCharIndexFromLine(_counter);
                richTextBoxToday.SelectionLength = this.richTextBoxToday.Lines[_counter].Length + 1;
                this.richTextBoxToday.SelectedText = String.Empty;                      
                _counter--;
                _gesamtSumme = _sum;
            } else if(_counter == 0)
            {
                _sum = 0;
                labGesamtSumme.Text = "0";
            }*/

            _counter = 0;
            _sum = 0;
            _gesamtSumme = 0;
            labGesamtSumme.Text = "";
            richTextBoxToday.Clear();
        }

        private void btnSaveHistory_Click(object sender, EventArgs e)
        {
            int id = (int)this.Tag;
            string updateText = richTextBox1.Text;
            SqliteDataAccess.UpdateKundenNotizen(id, updateText);
            MessageBox.Show("Historie aktualisiert");
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            int id = (int)this.Tag;
            string changesText = rtbChanges.Text;
            SqliteDataAccess.UpdateKundenChanges(id, changesText);
            MessageBox.Show("Änderungen gespeichert");
        }

        private void B_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
