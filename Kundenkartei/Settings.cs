using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundenkartei
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        //Vollbild
        private void ckbxFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbxFullScreen.Checked)
            {
                ChangeFullscreenMode("1");
            } else {
                ChangeFullscreenMode("0");
            }
        }

        private void ChangeFullscreenMode(string parameter)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Fullscreen"].Value = parameter;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }
    }
}
