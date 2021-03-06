﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            tbGeburtstag.Text = kunde.Geburtstag.ToString();
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
                item.SubItems.Add(GetAdditionalInformation(s, "Datum")[ind]);
                item.SubItems.Add(GetAdditionalInformation(s, "Dienstleistung")[ind]);
                item.SubItems.Add(GetAdditionalInformation(s, "Mitarbeiter")[ind]);
                metroListView1.Items.Add(item);
                ind++;
            }
        }

        private List<string> GetAdditionalInformation(Kunde s, string colName)
        {
            List<String> li = new List<string>();
            DataTable tab = SqliteDataAccess.Query(@"SELECT t.Datum, t.Dienstleistung, t.Mitarbeiter
                                                     FROM Kunden k
                                                     Inner Join Termine t
                                                     ON k.KundenNr = t.KundenNr
                                                      WHERE k.KundenNr = @kundenNr
                                                      ORDER BY t.Datum DESC", "kundenNr", s.KundenNr);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    li.Add(row[colName].ToString());
                }
            }
            return li;
        }

        private void CustomerHistory_Activated(object sender, EventArgs e)
        {            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (metroListView1.CheckedItems.Count == 1)
            {
                try
                {
                    int id = metroListView1.Items.IndexOf(metroListView1.CheckedItems[0]);
                    EditAppointment ea = new EditAppointment();
                    int kundenNr = Convert.ToInt32(metroListView1.CheckedItems[0].SubItems[1].Text.ToString());
                    DataTable kunde = SqliteDataAccess.GetKundeById(kundenNr);
                    Kunde k = new Kunde(Convert.ToInt32(kundenNr), kunde.Rows[0].ItemArray[1].ToString(), kunde.Rows[0].ItemArray[2].ToString());
                    DataTable termin = SqliteDataAccess.GetKundenHistorie(k);
                    Termin t = new Termin(Convert.ToInt32(termin.Rows[id]["TerminNr"]), termin.Rows[id]["Datum"].ToString(), termin.Rows[id]["Dienstleistung"].ToString(), termin.Rows[id]["Mitarbeiter"].ToString(), Convert.ToInt32(termin.Rows[id]["KundenNr"]));
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
            //Get actual customer notes to reference while object creation

            DataTable noteTab = SqliteDataAccess.Query("SELECT Notizen FROM Kunden WHERE KundenNr = @kundenNr", "kundenNr", Convert.ToInt32(tbKundenNr.Text));
            string notes = noteTab.Rows[0]["Notizen"].ToString();
            Kunde k = new Kunde(Convert.ToInt32(tbKundenNr.Text), tbName.Text, tbTelefon.Text, tbGeburtstag.Text ,tbAdresse.Text, tbPlz.Text, tbStadt.Text, tbMail.Text, notes);
            SqliteDataAccess.UpdateKunde(k);
            //MessageBox.Show("Änderungen gespeichert.");
            this.Close();
        }

        private void CustomerHistory_Load(object sender, EventArgs e)
        {
            this.Activate();
            metroListView1.Items.Clear();
            FillCustomerList();
        }
    }
}
