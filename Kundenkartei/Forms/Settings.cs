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
            if (ckbxFullScreen.Checked)
            { ChangeFullscreenMode(true); } else { ChangeFullscreenMode(false); }
        }
        

        private void ChangeFullscreenMode(bool parameter)
        {
            //if (parameter)
            //{
            //    MainForm.Self.WindowState = FormWindowState.Normal;
            //    MainForm.Self.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //    MainForm.Self.Bounds = Screen.PrimaryScreen.Bounds;
            //}
            //else
            //{
            //    MainForm.Self.WindowState = FormWindowState.Maximized;
            //    MainForm.Self.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //    MainForm.Self.SetBounds(0, 0, 1360, 720);
            //    this.Close();
            //}
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }
    }
}
