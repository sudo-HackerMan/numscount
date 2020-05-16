using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace УстныйСчет
{
    public partial class about : MetroFramework.Forms.MetroForm
    {
        string theme, dif;

        public about()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void about_Shown(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("settings.conf");
            theme = sr.ReadLine();
            dif = sr.ReadLine();

            if (theme == "theme=light")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Light;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }

            else if (theme == "theme=dark")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
            }

            sr.Close();
        }
    }
}
