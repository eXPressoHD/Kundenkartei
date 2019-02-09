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
    public partial class CustomerHistory : MetroFramework.Forms.MetroForm
    {
        public CustomerHistory()
        {
            InitializeComponent();
        }

        private void FillCustomerList()
        {
            Kunde kunde = this.Tag as Kunde;
            tbKundenNr.Text = kunde.KundenNr.ToString();
            tbName.Text = kunde.Name.ToString();
            tbTelefon.Text = kunde.Telefon.ToString();
            tbAdresse.Text = kunde.Strasse.ToString();
            tbPlz.Text = kunde.Plz.ToString();
            tbStadt.Text = kunde.Stadt.ToString();
            tbMail.Text = kunde.Email.ToString();
            List<Kunde> kundenListe = new List<Kunde>();
            DataTable table = new DataTable();
            table = SqliteDataAccess.GetKundenHistorie(kunde);
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
            int ind = 0;
            foreach (Kunde s in kundenListe)
            {

                
                ListViewItem item = new ListViewItem(s.Name)
                {
                    Font = new Font(new FontFamily("Microsoft Sans Serif"), 12.0f, FontStyle.Regular)
                };
                item.SubItems.Add(s.KundenNr.ToString());
                item.SubItems.Add(s.Telefon);
                item.SubItems.Add(GetDate(s)[ind]);
                item.SubItems.Add(GetDienstLeistung(s));
                item.SubItems.Add(GetMitarbeiter(s));
                metroListView1.Items.Add(item);
                ind++;
            }
        }

        //TODO: ändern dass er jede reihe durchgeht
        private List<string> GetDate(Kunde s)
        {
            List<String> li = new List<string>();
            DataTable tab = SqliteDataAccess.GetKundenTerminAndDienstleistungAll(s);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    li.Add(row["Datum"].ToString());
                }
            }

            return li;
        }

        private string GetDienstLeistung(Kunde s)
        {
            DataTable tab = SqliteDataAccess.GetKundenTerminAndDienstleistungAll(s);
            if (tab.Rows.Count > 0)
            {
                return tab.Rows[0].ItemArray[1].ToString();
            }
            else
            {
                return "";
            }
        }

        private string GetMitarbeiter(Kunde s)
        {
            DataTable tab = SqliteDataAccess.GetKundenTerminAndDienstleistungAll(s);
            if (tab.Rows.Count > 0)
            {
                return tab.Rows[0].ItemArray[2].ToString();
            }
            else
            {
                return "";
            }
        }

        private void CustomerHistory_Activated(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            FillCustomerList();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (metroListView1.CheckedItems.Count == 1)
            {
                try
                {
                    int kundenNr = Convert.ToInt32(metroListView1.CheckedItems[0].SubItems[1].Text.ToString());
                    DataTable kunde = SqliteDataAccess.GetKundeById(kundenNr);
                    Kunde k = new Kunde(Convert.ToInt32(kundenNr), kunde.Rows[0].ItemArray[1].ToString(), kunde.Rows[0].ItemArray[2].ToString());
                    DataTable termin = SqliteDataAccess.GetKundenHistorie(k);
                    Termin t = new Termin(Convert.ToInt32(termin.Rows[0]["TerminNr"]), termin.Rows[0]["Datum"].ToString(), termin.Rows[0]["Dienstleistung"].ToString(), termin.Rows[0]["Mitarbeiter"].ToString(), Convert.ToInt32(termin.Rows[0]["KundenNr"]));
                    EditAppointment ea = new EditAppointment();
                    ea.Tag = t;
                    ea.Show();
                }
                catch (Exception ex)
                {
                    throw(ex);
                }
            }
            else
            {
                MessageBox.Show("Bitte einen Termin auswählen");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Kunde k = new Kunde(Convert.ToInt32(tbKundenNr.Text), tbName.Text, tbTelefon.Text, tbAdresse.Text, tbPlz.Text, tbStadt.Text, tbMail.Text);
            SqliteDataAccess.UpdateKunde(k);
            MessageBox.Show("Änderungen gespeichert.");          
            this.Close();
        }
    }
}
