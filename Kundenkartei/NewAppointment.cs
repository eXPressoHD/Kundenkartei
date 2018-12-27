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
                k.LetzterTermin = row["Termin"].ToString();
                k.Dienstleistung = row["Dienstleistung"].ToString();
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
                item.SubItems.Add(s.LetzterTermin);
                item.SubItems.Add(s.Dienstleistung);
                metroListView1.Items.Add(item);
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
    }
}
