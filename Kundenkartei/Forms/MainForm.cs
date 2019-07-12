using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundenkartei
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        //Static logger class, TODO: Instead use Diagnostics with NLog Listener in config
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        //Static object to access from all forms
        public static MainForm Self;

        /// <summary>
        /// Main Constructor
        /// </summary>
        public MainForm()
        {
            Self = this;
            InitializeComponent();
            TodayDatetime.Text = DateTime.Now.ToString("dd.MM.yyyy");
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = true;
            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
        }

        /// <summary>
        /// Neuen Kunden hinzufügen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateKunde_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddCustomerForm"] as AddCustomerForm) != null)
            {
                //Form is already open
            }
            else
            {
                AddCustomerForm kundenForm = new AddCustomerForm();
                kundenForm.Show();
            }
        }

        /// <summary>
        /// Lookup all Customers in DB an display them in ListView
        /// </summary>
        private void FillCustomerList()
        {
            List<Kunde> kundenListe = new List<Kunde>();
            DataTable table = new DataTable();
            if (!metroRadioButton1.Checked)
            {
                // table = SqliteDataAccess.GetKundenData();
                table = SqliteDataAccess.Query("SELECT * FROM KUNDEN");
            }
            else
            {
                table = SqliteDataAccess.Query(@"SELECT * FROM Kunden k Inner join Termine t ON k.KundenNr = t.KundenNr WHERE t.Datum Like @today ORDER BY t.Datum asc", "today", String.Format("%" + DateTime.Today.ToString("dd.MM.yyyy") + "%"));
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

            DateTime date = Convert.ToDateTime(TodayDatetime.Text);
            string strDate = date.ToString("dd.MM.yyyy");
            string sqlFormat = String.Format("{0}%", strDate);

            foreach (Kunde s in kundenListe)
            {

                ListViewItem item = new ListViewItem(s.Name)
                {
                    Font = new Font(new FontFamily("Microsoft Sans Serif"), 13.0f, FontStyle.Regular)
                };

                item.SubItems.Add(s.KundenNr.ToString());
                item.SubItems.Add(s.Telefon);
                item.SubItems.Add(ReturnSingleValue(s, "Geburtstag", SqlFunction.Birthday));
                item.SubItems.Add(ReturnSingleValue(s, "Adresse", SqlFunction.Adress));
                item.SubItems.Add(ReturnSingleValue(s, "Email", SqlFunction.Email));
                metroListView1.Items.Add(item);
                foreach (ColumnHeader column in metroListView1.Columns) //Set width of columns automatically
                {
                    //column.Width = -2;
                }
            }
        }

        enum SqlFunction { terminDienstleistung = 1, Birthday = 2, Adress = 3, Email = 4 };

        private string ReturnSingleValue(Kunde k, string columnName, SqlFunction function)
        {
            DataTable dt = new DataTable();

            switch(function)
            {
                case SqlFunction.Birthday:
                    dt = SqliteDataAccess.Query(@"SELECT Geburtstag 
                                                  FROM Kunden 
                                                  WHERE KundenNr = @kundenNr", "kundenNr", k.KundenNr);
                    break;
                case SqlFunction.Adress:
                    dt = SqliteDataAccess.Query(@"SELECT Strasse, PLZ, Stadt
                                                  FROM Kunden 
                                                  WHERE KundenNr = @kundenNr", "kundenNr", k.KundenNr);
                    break;
                case SqlFunction.Email:
                    dt = SqliteDataAccess.Query(@"SELECT Email 
                                                  FROM Kunden 
                                                  WHERE KundenNr = @kundenNr", "kundenNr", k.KundenNr);
                    break;
            }


            if (columnName != "Adresse")
            {
                if (dt.Rows.Count == 1)
                {
                    return dt.Rows[0][columnName].ToString();
                }
                else
                {
                    return String.Empty;
                }
            } else
            {
                string adresse = dt.Rows[0]["Strasse"].ToString() + " " + dt.Rows[0]["PLZ"].ToString() + " " + dt.Rows[0]["Stadt"].ToString();
                return adresse;
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            metroListView1.BeginUpdate();
            metroListView1.Items.Clear();
            FillCustomerList();
            metroListView1.EndUpdate();
        }

        /// <summary>
        /// Ausgewählten Kunden löschen mit vorheriger Frage ob man ihn löschen will
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroListView1.CheckedItems.Count == 1)
            {
                string kundenNr = metroListView1.CheckedItems[0].SubItems[1].Text;
                DialogResult dialogResult = MessageBox.Show("Kunde wirklich löschen?", "Kunde löschen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqliteDataAccess.ExecuteNonQuery("DELETE FROM Kunden WHERE KundenNr = @kundenNr", "kundenNr", kundenNr);
                    metroListView1.Items.Clear();
                    FillCustomerList();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
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
            }
            else
            {
                metroListView1.BeginUpdate();
                metroListView1.Items.Clear();
                FillCustomerList();
                metroListView1.EndUpdate();
            }
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
            if (metroListView1.CheckedItems.Count == 1)
            {
                try
                {
                    int kundenNr = Convert.ToInt32(metroListView1.CheckedItems[0].SubItems[1].Text.ToString());
                    DataTable kunde = SqliteDataAccess.GetKundeById(kundenNr);
                    Kunde k = new Kunde(Convert.ToInt32(kundenNr), kunde.Rows[0].ItemArray[1].ToString(), kunde.Rows[0].ItemArray[2].ToString(), kunde.Rows[0]["Strasse"].ToString(), kunde.Rows[0]["PLZ"].ToString(), kunde.Rows[0]["Stadt"].ToString(), kunde.Rows[0]["Email"].ToString());
                    NewAppointment neuerTermin = new NewAppointment();
                    neuerTermin.Tag = k;
                    neuerTermin.Show();
                }
                catch (Exception ex)
                {
                    _logger.Error(ex);
                }
            }
            else
            {
                NewAppointment neuerTermin = new NewAppointment();
                neuerTermin.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Activate();
            _logger.Debug("Application started...");
        }


        /// <summary>
        /// Kundeninformationen anzeigen anhand der ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (metroListView1.CheckedItems.Count == 1)
            {
                try
                {
                    int kundenNr = Convert.ToInt32(metroListView1.CheckedItems[0].SubItems[1].Text.ToString());
                    DataTable kunde = SqliteDataAccess.GetKundeById(kundenNr);
                    Kunde k = new Kunde(Convert.ToInt32(kundenNr), kunde.Rows[0]["Name"].ToString(), kunde.Rows[0]["Telefon"].ToString(), kunde.Rows[0]["Geburtstag"].ToString(), kunde.Rows[0]["Strasse"].ToString(), kunde.Rows[0]["PLZ"].ToString(), kunde.Rows[0]["Stadt"].ToString(), kunde.Rows[0]["Email"].ToString());
                    CustomerHistory ch = new CustomerHistory();
                    ch.Tag = k;
                    if ((Application.OpenForms["CustomerHistory"] as CustomerHistory) != null)
                    {
                        //Form is already open
                    }
                    else
                    {
                        ch.Show();
                    }
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

        private void metroButton5_Click(object sender, EventArgs e)
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
                    _logger.Error("Kein Termin verfügbar");
                    _logger.Error(ex);
                }
            }
            else
            {
                MessageBox.Show("Bitte einen Kunden auswählen");
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            FillCustomerList();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            FillCustomerList();
        }

        private void metroListView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item as ListViewItem;
            if (item.Checked)
            {
                item.BackColor = Color.LightGray;
            }
            else
            {
                item.BackColor = Color.White;
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (metroListView1.CheckedItems.Count == 1)
            {
                int kundenNr = Convert.ToInt32(metroListView1.CheckedItems[0].SubItems[1].Text.ToString());
                ShowCustomerNotes n = new ShowCustomerNotes();
                n.Tag = kundenNr;

                if ((Application.OpenForms["ShowCustomerNotes"] as ShowCustomerNotes) != null)
                {
                    //Form is already open
                }
                else
                {
                    n.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Bitte einen Kunden auswählen");
            }
        }

        /// <summary>
        /// Close Applictation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
}
