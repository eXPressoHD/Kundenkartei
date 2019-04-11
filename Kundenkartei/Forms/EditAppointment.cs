using System;

namespace Kundenkartei
{
    public partial class EditAppointment : MetroFramework.Forms.MetroForm
    {
        public EditAppointment()
        {
            InitializeComponent();
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {
            Termin t = this.Tag as Termin;
            FillData(t);            
        }

        private void FillData(Termin t)
        {
            tbTerminNr.Text = t.TerminNr.ToString();
            string[] dates = t.Datum.Split(new char[0]);
            DateTime date1 = Convert.ToDateTime(dates[0]);
            DateTime date2 = Convert.ToDateTime(dates[1]);
            dateTimePicker1.Text = date1.ToString("dd.MM.yyyy");
            dateTimePicker2.Text = date2.ToString("HH:mm");
            metroTextBox1.Text = t.Dienstleistung;
            tbMitarbeiter.Text = t.Mitarbeiter;
            tbKundenNr.Text = t.KundenNr.ToString();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string fullDate = String.Format("{0} {1}", dateTimePicker1.Value.ToString("dd.MM.yyyy"), dateTimePicker2.Value.ToString("HH:mm"));
            Termin t = new Termin(Convert.ToInt32(tbTerminNr.Text), fullDate, metroTextBox1.Text, tbMitarbeiter.Text, Convert.ToInt32(tbKundenNr.Text));
            try
            {
                SqliteDataAccess.UpdateTermin(t);
                this.Close();
            } catch(Exception ex)
            {
                throw (ex);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string fullDate = String.Format("{0} {1}", dateTimePicker1.Value.ToString("dd.MM.yyyy"), dateTimePicker2.Value.ToString("HH:mm"));
            Termin t = new Termin(Convert.ToInt32(tbTerminNr.Text), fullDate, metroTextBox1.Text, tbMitarbeiter.Text, Convert.ToInt32(tbKundenNr.Text));
            try
            {                
                SqliteDataAccess.DeleteTermin(t);
                this.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
