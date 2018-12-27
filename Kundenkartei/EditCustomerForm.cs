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
    public partial class EditCustomerForm : MetroFramework.Forms.MetroForm
    {
        public MetroFramework.Controls.MetroTextBox TextBoxKundenNr
        {
            get { return tbKundenNr; }
            set { tbKundenNr = value; }
        }

        public MetroFramework.Controls.MetroTextBox TextBoxName
        {
            get { return tbName; }
            set { tbName = value; }
        }


        public MetroFramework.Controls.MetroTextBox TextBoxTelefon
        {
            get { return tbTelefon; }
            set { tbTelefon = value; }
        }

        public MetroFramework.Controls.MetroTextBox TextBoxDienstleistung
        {
            get { return tbDienstleistung; }
            set { tbDienstleistung = value; }
        }

        public EditCustomerForm()
        {
            InitializeComponent();
        }

        private void Kunde_anlegen_Click(object sender, EventArgs e)
        {
            var uhrzeit = dateTimePickerDate.Text + " " + dateTimePickerTime.Text;
            Kunde k = new Kunde(Convert.ToInt32(tbKundenNr.Text), tbName.Text, tbTelefon.Text, uhrzeit.ToString(), tbDienstleistung.Text);
            SqliteDataAccess.UpdateKunde(k);
            this.Close();
        }
    }
}
