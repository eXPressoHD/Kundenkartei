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
            this.Close();
        }
    }
}
