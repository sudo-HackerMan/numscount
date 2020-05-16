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
    public partial class settings : MetroFramework.Forms.MetroForm
    {
        string theme, dif, q;

        public settings()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (metroTile2.Style == MetroFramework.MetroColorStyle.Green)
            {
                File.WriteAllText("settings.conf", $"theme=light\n{(trackBar1.Value).ToString()}\n{trackBar2.Value.ToString()}");
            }
            
            else
            {
                File.WriteAllText("settings.conf", $"theme=dark\n{(trackBar1.Value).ToString()}\n{trackBar2.Value.ToString()}");
            }
            this.Visible = false;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            metroTile3.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            //this.Visible = false;
            //this.Visible = true;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroTile3.Style = MetroFramework.MetroColorStyle.Green;
            metroTile2.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            //this.Visible = false;
            //this.Visible = true;
        }

        private void settings_Shown(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("settings.conf");
            theme = sr.ReadLine();
            dif = sr.ReadLine();
            q = sr.ReadLine();

            if (theme == "theme=light")
            {
                metroTile2.Style = MetroFramework.MetroColorStyle.Green;
                this.Theme = MetroFramework.MetroThemeStyle.Light;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;
                label18.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;
            }

            if (theme == "theme=dark")
            {
                metroTile3.Style = MetroFramework.MetroColorStyle.Green;
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label13.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label17.ForeColor = Color.White;
                label18.ForeColor = Color.White;
                label19.ForeColor = Color.White;
            }

            trackBar1.Value = Convert.ToInt32(dif);
            trackBar2.Value = Convert.ToInt32(q);

            sr.Close();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
