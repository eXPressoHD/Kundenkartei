using System;
using System.Windows.Forms;

namespace Kundenkartei
{
    public partial class AddCustomerForm : MetroFramework.Forms.MetroForm
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void Kunde_anlegen_Click(object sender, EventArgs e)
        {
            Kunde kunde = new Kunde(Convert.ToInt32(SqliteDataAccess.GetLatestKundenNr()),tbName.Text, tbTelefon.Text, tbGeburtstag.Text, tbAdresse.Text, tbPlz.Text, tbStadt.Text, tbMail.Text);
            kunde.WriteKundeToDB();
            ClearControls();
        }

        private void ClearControls()
        {
            foreach (Control control in this.Controls)
            {
                if (control is MetroFramework.Controls.MetroTextBox)
                {
                    (control as MetroFramework.Controls.MetroTextBox).Clear();
                } else
                {

                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
