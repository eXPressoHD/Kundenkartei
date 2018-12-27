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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        public Main()
        {
            InitializeComponent();
        }

        private void CreateKunde_Click(object sender, EventArgs e)
        {
            AddCustomerForm kundenForm = new AddCustomerForm();
            kundenForm.Show();            
        }

        private void FillCustomerList()
        {
            List<Kunde> kundenListe = new List<Kunde>();
            DataTable table = new DataTable();
            if (!metroCheckBoxTermineHeute.Checked)
            {
                table = SqliteDataAccess.GetKundenData();
            } else
            {
                table = SqliteDataAccess.GetKundenDataToday();
            }
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

        /*
        private void SucheKunden_Click(object sender, EventArgs e)
        {
            List<Kunde> lookUpList = new List<Kunde>();
            DataTable tab = SqliteDataAccess.LookUpKunde(tbKundenName.Text);
            foreach(DataRow row in tab.Rows)
            {
                Kunde k = new Kunde();
                k.KundenNr = Convert.ToInt32(row["KundenNr"]);
                k.Name = row["Name"].ToString();
                k.Telefon = row["Telefon"].ToString();

                string test = String.Format("{0} {1} {2}", k.KundenNr, k.Name, k.Telefon);
                lookUpList.Add(k);
            }
            if (lookUpList.Count > 0)
            {
                listBox1.Items.Clear();
                foreach (Kunde s in lookUpList)
                {
                    ListViewItem item = new ListViewItem(s.Name);
                    item.Font = new Font(new FontFamily("Microsoft Sans Serif"), 12.0f, FontStyle.Regular);
                    item.SubItems.Add(s.Name);
                    item.SubItems.Add(s.Telefon);
                    metroListView1.Items.AddRange(new ListViewItem[] { item });
                   // listBox1.Items.Add(s.Format());
                }
                tbKundenName.Text = String.Empty;
            } else
            {
                MessageBox.Show("Keinen Kunden gefunden");
                tbKundenName.Text = String.Empty;
            }
        }
        
        private void SucheLeeren_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FillCustomerList();
        }*/

        private void Main_Activated(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            FillCustomerList();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroListView1.CheckedItems.Count == 1)
            {
                try
                {
                    int kundenNr = Convert.ToInt32(metroListView1.CheckedItems[0].SubItems[1].Text.ToString());
                    DataTable kunde = SqliteDataAccess.GetKundeById(kundenNr);
                    EditCustomerForm form = new EditCustomerForm();
                    form.TextBoxKundenNr.Text = kundenNr.ToString();
                    form.TextBoxName.Text = kunde.Rows[0].ItemArray[1].ToString();
                    form.TextBoxTelefon.Text = kunde.Rows[0].ItemArray[2].ToString();
                    form.TextBoxDienstleistung.Text = kunde.Rows[0].ItemArray[4].ToString();
                    form.Show();
                }catch(Exception ex)
                {
                    _logger.Error(ex);
                }
            } else
            {
                MessageBox.Show("Bitte einen Kunden auswählen");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroListView1.SelectedItems.Count == 1)
            {
                try
                {
                    int kundenNr = Convert.ToInt32(metroListView1.CheckedItems[0].SubItems[1].Text.ToString());
                    DataTable kunde = SqliteDataAccess.GetKundeById(kundenNr);
                    Kunde k = new Kunde(Convert.ToInt32(kundenNr), kunde.Rows[0].ItemArray[1].ToString(), kunde.Rows[0].ItemArray[2].ToString());
                    SqliteDataAccess.DeleteKunde(k);
                    metroListView1.Items.Clear();
                    FillCustomerList();
                }catch(Exception ex)
                {
                    _logger.Error(ex);
                }
            }
            else
            {
                MessageBox.Show("Bitte einen Kunden auswählen");
            }
        }

        private void tbKundenName_TextChanged(object sender, EventArgs e)
        {
                if (tbKundenName.Text != "")
                {
                    for (int i = metroListView1.Items.Count - 1; i >= 0; i--)
                    {
                        var item = metroListView1.Items[i];
                        if (item.Text.ToLower().Contains(tbKundenName.Text.ToLower()))
                        {
                            item.BackColor = SystemColors.Highlight;
                            item.ForeColor = SystemColors.HighlightText;
                        }
                        else
                        {
                            metroListView1.Items.Remove(item);
                        }
                    }
                    if (metroListView1.SelectedItems.Count == 1)
                    {
                    metroListView1.Focus();
                    }
                } else {
                metroListView1.Items.Clear();
                FillCustomerList();
            }                   
            }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearSearch_Click(object sender, EventArgs e)
        {
            tbKundenName.Text = String.Empty;
        }

        private void metroCheckBoxTermineHeute_CheckedChanged(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            FillCustomerList();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            NewAppointment neuerTermin = new NewAppointment();
            neuerTermin.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
