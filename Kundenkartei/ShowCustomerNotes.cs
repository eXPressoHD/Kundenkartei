using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundenkartei
{
    public partial class ShowCustomerNotes : MetroFramework.Forms.MetroForm
    {
        public ShowCustomerNotes()
        {
            InitializeComponent();
            FetchTypes();            
        }

        private void FetchTypes()
        {
            List<String> types = new List<string>();
            DataTable tab = SqliteDataAccess.GetCustomerTypes();
            foreach(DataRow row in tab.Rows)
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

            if(box.Text == "Herren")
            {
               preisTab = SqliteDataAccess.GetPriceList("Herren");
            } else if(box.Text == "Damen")
            {
                preisTab = SqliteDataAccess.GetPriceList("Damen");
            } else if(box.Text == "Kids")
            {
                preisTab = SqliteDataAccess.GetPriceList("Kids");
            }

            foreach(DataRow row in preisTab.Rows)
            {
                preisListe.Add(String.Format("{0} - {1}", row["Titel"].ToString(), row["Preis"].ToString() + "€"));
            }

            listBox1.Items.AddRange(preisListe.ToArray());
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            richTextBox1.Text += text;
            richTextBox1.Text += Environment.NewLine;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            int kundenNr = (int)this.Tag;
            DataTable kunde = SqliteDataAccess.GetKundeById(kundenNr);
            Kunde k = new Kunde(Convert.ToInt32(kundenNr), kunde.Rows[0].ItemArray[1].ToString(), kunde.Rows[0].ItemArray[2].ToString());
            k.Notizen = richTextBox1.Text;
            SqliteDataAccess.UpdateKunde(k);
            this.Close();
        }

        private void ShowCustomerNotes_Load(object sender, EventArgs e)
        {
            int id = (int)this.Tag;
            DataTable kunde = SqliteDataAccess.GetKundeById(id);
            Kunde k = new Kunde(Convert.ToInt32(id), kunde.Rows[0].ItemArray[1].ToString(), kunde.Rows[0].ItemArray[2].ToString());
            labName.Text = k.Name;
            labKundenNr.Text = id.ToString();
            FetchNotes();
            customerTypeChoose.Text = "Damen";
        }

        private void FetchNotes()
        {
            int nr = (int)this.Tag;
            DataTable notes = SqliteDataAccess.GetKundenNotes(nr);
            string text = notes.Rows[0].ItemArray[0].ToString();
            richTextBox1.Text = text;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += DateTime.Now.ToString("dd.MM.yyyy");
            richTextBox1.Text += Environment.NewLine;
        }
    }
}
