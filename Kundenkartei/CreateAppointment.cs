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
    public partial class CreateAppointment : MetroFramework.Forms.MetroForm
    {
        public Kunde vorgelegt = new Kunde();

        public CreateAppointment()
        {
            InitializeComponent();
        }

        private void tbKundenName_TextChanged(object sender, EventArgs e)
        {
            if (tbKundenName.Text != "")
            {
                for (int i = CustomerList.Items.Count - 1; i >= 0; i--)
                {
                    var item = CustomerList.Items[i];
                    if (item.Text.ToLower().Contains(tbKundenName.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        CustomerList.Items.Remove(item);
                    }
                }
                if (CustomerList.SelectedItems.Count == 1)
                {
                    CustomerList.Focus();
                }
            }
            else
            {
                CustomerList.Items.Clear();
                FillCustomerList();
            }
        }

        private void FillCustomerList()
        {
            List<Kunde> kundenListe = new List<Kunde>();
            DataTable table = new DataTable();
            table = SqliteDataAccess.GetKundenData();
            
            foreach (DataRow row in table.Rows)
            {
                Kunde k = new Kunde
                {
                    KundenNr = Convert.ToInt32(row["KundenNr"]),
                    Name = row["Name"].ToString(),
                    Telefon = row["Telefon"].ToString(),
                };
                kundenListe.Add(k);
            }

            foreach (Kunde s in kundenListe)
            {
                ListViewItem item = new ListViewItem(s.Name)
                {
                    Font = new Font(new FontFamily("Microsoft Sans Serif"), 12.0f, FontStyle.Regular)
                };
                item.SubItems.Add(s.KundenNr.ToString());
                item.SubItems.Add(s.Telefon);
                CustomerList.Items.Add(item);           
            } 
        }

        //Wenn Custome ausgewählt ist...
        private void FillCustomerListWithFoundCustomer()
        {
            List<Kunde> kundenListe = new List<Kunde>();
            DataTable tab = SqliteDataAccess.GetKundeById(vorgelegt.KundenNr);
            foreach (DataRow row in tab.Rows)
            {
                Kunde k = new Kunde
                {
                    KundenNr = Convert.ToInt32(row["KundenNr"]),
                    Name = row["Name"].ToString(),
                    Telefon = row["Telefon"].ToString(),
                };
                kundenListe.Add(k);
            }

            foreach (Kunde s in kundenListe)
            {
                ListViewItem item = new ListViewItem(s.Name)
                {
                    Font = new Font(new FontFamily("Microsoft Sans Serif"), 12.0f, FontStyle.Regular)
                };
                item.SubItems.Add(s.KundenNr.ToString());
                item.SubItems.Add(s.Telefon);
                item.Checked = true;
                CustomerList.Items.Add(item);
            }
        }

        private void CreateAppointment_Activated(object sender, EventArgs e)
        {
            var date = this.Tag;
            if (date != null)
            {
                dateTimePicker1.Value = Convert.ToDateTime(date);
            }
            CustomerList.Items.Clear();
            if (vorgelegt.KundenNr != 0)
            {
                FillCustomerListWithFoundCustomer();
            }
            else
            {
                FillCustomerList();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (CustomerList.CheckedItems.Count == 1) {
                string date = dateTimePicker1.Value.ToString("dd.MM.yyyy") + " " + dateTimePicker2.Value.ToString("HH:mm");
                int kundenNr = Convert.ToInt32(CustomerList.CheckedItems[0].SubItems[1].Text.ToString());
                Termin t = new Termin(date, metroTextBox1.Text, tbMitarbeiter.Text, kundenNr);
                SqliteDataAccess.CreateTermin(t);
                this.Close();
            } else
            {
                MessageBox.Show("Bitte einen Kunden auswählen");
            }
        }

        private void ClearSearch_Click(object sender, EventArgs e)
        {
            tbKundenName.Text = String.Empty;
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CustomerList.Items.Clear();
            FillCustomerList();
        }
    }
}
