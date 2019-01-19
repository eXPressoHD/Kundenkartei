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
    public partial class NewAppointment : MetroFramework.Forms.MetroForm
    {
        public NewAppointment()
        {
            InitializeComponent();
        }

        private void FillCustomerList()
        {
            List<Kunde> kundenListe = new List<Kunde>();
            DataTable table = new DataTable();
            
            table = SqliteDataAccess.GetKundenDataOnDate(dateTimePicker1.Value);
            foreach (DataRow row in table.Rows)
            {
                Kunde k = new Kunde();
                k.KundenNr = Convert.ToInt32(row["KundenNr"]);
                k.Name = row["Name"].ToString();
                k.Telefon = row["Telefon"].ToString();
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
                item.SubItems.Add(GetDate(s));
                item.SubItems.Add(GetDienstLeistung(s));
                item.SubItems.Add(GetMitarbeiter(s));
                metroListView1.Items.Add(item);
            }
        }

        private string GetDate(Kunde s)
        {
            DataTable tab = SqliteDataAccess.GetKundenTerminAndDienstleistung(s);
            if (tab.Rows.Count > 0)
            {
                return tab.Rows[0].ItemArray[0].ToString();
            } else
            {
                return "";
            }
        }    
        
        private string GetDienstLeistung(Kunde s)
        {
            DataTable tab = SqliteDataAccess.GetKundenTerminAndDienstleistung(s);
            if (tab.Rows.Count > 0)
            {
                return tab.Rows[0].ItemArray[1].ToString();
            } else
            {
                return "";
            }
        }

        private string GetMitarbeiter(Kunde s)
        {
            DataTable tab = SqliteDataAccess.GetKundenTerminAndDienstleistung(s);
            if (tab.Rows.Count > 0)
            {
                return tab.Rows[0].ItemArray[2].ToString();
            }
            else
            {
                return "";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            FillCustomerList();
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            FillCustomerList();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                CreateAppointment c = new CreateAppointment();
                c.Tag = dateTimePicker1.Value;
                c.vorgelegt = this.Tag as Kunde;
                c.Show();
            } else
            {
                CreateAppointment c = new CreateAppointment();
                c.Tag = dateTimePicker1.Value;
                c.Show();
            }
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
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
                    throw (ex);
                }
            }
            else
            {
                MessageBox.Show("Bitte einen Termin auswählen");
            }
        }

        private void NewAppointment_Activated(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            FillCustomerList();
        }
    }
}
