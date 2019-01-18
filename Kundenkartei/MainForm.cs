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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();        

        public MainForm()
        {
            InitializeComponent();
            metroCheckBoxTermineHeute.Checked = true;
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
            }
            else
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
            }
            else
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
            if (metroListView1.CheckedItems.Count == 1)
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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (metroListView1.CheckedItems.Count == 1)
            {
                try
                {
                    int kundenNr = Convert.ToInt32(metroListView1.CheckedItems[0].SubItems[1].Text.ToString());
                    DataTable kunde = SqliteDataAccess.GetKundeById(kundenNr);
                    Kunde k = new Kunde(Convert.ToInt32(kundenNr), kunde.Rows[0].ItemArray[1].ToString(), kunde.Rows[0].ItemArray[2].ToString());
                    CustomerHistory ch = new CustomerHistory();
                    ch.Tag = k;
                    ch.Show();
                }
                catch (Exception ex)
                {
                    _logger.Error(ex);
                }
            }
            else
            {
                MessageBox.Show("Bitte einen Kunden auswählen");
            }
        }
    }
}
