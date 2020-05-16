using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace УстныйСчет
{
    public partial class game : MetroFramework.Forms.MetroForm
    {
        bool end_current_question = false;
        string theme, dif, q;
        Random rnd = new Random();
        string[] act = new string[6] { "+", "-", "*", "/", "^", "%" };
        Int32[] div = new int[37] { 4, 6, 8, 10, 12, 14, 16, 18, 20, 9, 12, 15, 18, 21, 24, 27, 30, 
            28, 32, 36, 40, 25, 35, 45, 50, 42, 48, 54, 60, 49, 56, 63, 70, 64, 72, 80, 81};
        Int32 a, b, c;
        Int32 r = 0;
        float myAns;
        float tmp;
        String action;
        Int32 score = 0;
        Int32[] mul3 = new int[2] { 2, 10 };
        Int32[] mul5 = new int[5] { 2, 10, 100, 1000, 10000 };
        Int32 _tmp;
        Int32 __tmp;
        Int32[] per = new int[9] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

        void visFalse()
        {
            numsLabel.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            metroTile2.Visible = false;
            metroTile3.Visible = false;
            metroTile4.Visible = false;
            metroTile7.Visible = false;
            metroTile6.Visible = false;
            metroTile5.Visible = false;
            metroTile10.Visible = false;
            metroTile9.Visible = false;
            metroTile8.Visible = false;
            metroTile14.Visible = false;
            metroTile13.Visible = false;
            metroTile12.Visible = false;
            metroTile11.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        void toLabel(Label lbl, string text, Color color)
        {
            Action action = () => toLabel(lbl, text, color);
            if (InvokeRequired)
            {
                Invoke(action);
            }

            else
            {
                lbl.Text = text;
                lbl.ForeColor = color;
            }         
        }

        void timeMethod()
        {     
            StreamReader sr = new StreamReader("settings.conf");
            theme = sr.ReadLine();
            dif = sr.ReadLine();
            q = sr.ReadLine();
            sr.Close();
            for (int i = 0; i < Convert.ToInt32(q); i++)
            {
                toLabel(label8, $"Вопрос {i + 1}/{q}", label8.ForeColor);
                if (dif == "1")
                {
                    c = rnd.Next(0, 2);
                    action = act[c];

                    a = rnd.Next(0, 20);
                    b = rnd.Next(0, 20);

                    if (action == "+")
                    {
                        while (a + b > 20)
                        {
                            a = rnd.Next(0, 20);
                            b = rnd.Next(0, 20);
                        }
                    }

                    else
                    {
                        while (a - b < 0)
                        {
                            a = rnd.Next(0, 20);
                            b = rnd.Next(0, 20);
                        }
                    }
                    toLabel(label2, $"{a.ToString()} {action} {b.ToString()}", label2.ForeColor);

                    while (end_current_question == false)
                    {
                        Thread.Sleep(1000);
                        if (end_current_question)
                        {
                            if (textBox1.Text != "")
                            {
                                myAns = Convert.ToInt32(textBox1.Text);

                                if (checkAns(myAns, a, b, action, r) == 1)
                                {
                                    toLabel(label6, "OK", Color.Green);
                                    end_current_question = false;
                                    score += 1;
                                }
                                else
                                {
                                    toLabel(label6, "BAD", Color.Red);
                                    end_current_question = false;
                                }
                                break;
                            }

                            else
                            {
                                toLabel(label6, "BAD", Color.Red);
                                end_current_question = false;
                                break;
                            }
                        }
                    }
                    toLabel(label4, "30", label4.ForeColor);
                }

                else if (dif == "2")
                {
                    c = rnd.Next(0, 4);
                    action = act[c];

                    if (action == "+")
                    {
                        a = rnd.Next(0, 100);
                        b = rnd.Next(0, 100);
                        while (a + b > 100)
                        {
                            a = rnd.Next(0, 100);
                            b = rnd.Next(0, 100);
                        }
                    }

                    else if (action == "-")
                    {
                        a = rnd.Next(0, 100);
                        b = rnd.Next(0, 100);
                        while (a - b < 0)
                        {
                            a = rnd.Next(0, 100);
                            b = rnd.Next(0, 100);
                        }
                    }

                    else if (action == "*")
                    {
                        a = rnd.Next(0, 10);
                        b = rnd.Next(0, 10);
                    }

                    else if (action == "/")
                    {
                        a = div[rnd.Next(0, 37)];
                        b = div[rnd.Next(0, 37)];

                        while (a % b != 0 || a / b > 9 || b > 9)
                        {
                            a = div[rnd.Next(0, 37)];
                            b = div[rnd.Next(0, 37)];
                        }              
                    }
                    toLabel(label2, $"{a.ToString()} {action} {b.ToString()}", label2.ForeColor);

                    while (end_current_question == false)
                    {
                        Thread.Sleep(1000);
                        if (end_current_question)
                        {
                            if (textBox1.Text != "")
                            {
                                myAns = Convert.ToInt32(textBox1.Text);

                                if (checkAns(myAns, a, b, action, r) == 1)
                                {
                                    toLabel(label6, "OK", Color.Green);
                                    end_current_question = false;
                                    score += 1;
                                }
                                else
                                {
                                    toLabel(label6, "BAD", Color.Red);
                                    end_current_question = false;
                                }
                                break;
                            }

                            else
                            {
                                toLabel(label6, "BAD", Color.Red);
                                end_current_question = false;
                                break;
                            }
                        }
                    }
                    toLabel(label4, "30", label4.ForeColor);
                    a = 1;
                    b = 2;
                }

                else if (dif == "3")
                {
                    c = rnd.Next(0, 4);
                    action = act[c];

                    if (action == "+")
                    {
                        a = rnd.Next(0, 1000);
                        b = rnd.Next(0, 1000);
                        while (a + b > 1000 || a % 10 != 0 || b % 10 != 0)
                        {
                            a = rnd.Next(0, 1000);
                            b = rnd.Next(0, 1000);
                        }
                    }

                    else if (action == "-")
                    {
                        a = rnd.Next(0, 1000);
                        b = rnd.Next(0, 1000);
                        while (a - b < 0 || a % 10 != 0 || b % 10 != 0)
                        {
                            a = rnd.Next(0, 1000);
                            b = rnd.Next(0, 1000);
                        }
                    }

                    else if (action == "*")
                    {
                        _tmp = rnd.Next(0, 2);

                        if (_tmp == 0)
                        {
                            a = rnd.Next(0, 10);
                            b = rnd.Next(0, 10);
                        }
                        
                        else
                        {
                            __tmp = rnd.Next(0, 2);
                            if (__tmp == 0)
                            {
                                a = rnd.Next(10, 100);
                                b = 2;
                            }

                            else
                            {
                                a = rnd.Next(10, 100);
                                b = 10;
                            }
                        }
                    }

                    else if (action == "/")
                    {
                        _tmp = rnd.Next(0, 2);

                        if (_tmp == 0)
                        {
                            a = div[rnd.Next(0, 37)];
                            b = div[rnd.Next(0, 37)];

                            while (a % b != 0 || a / b > 9 || b > 9)
                            {
                                a = div[rnd.Next(0, 37)];
                                b = div[rnd.Next(0, 37)];
                            }
                        }
                        
                        else
                        {
                            a = rnd.Next(10, 100);
                            b = mul3[rnd.Next(0, 2)];

                            while (a % b != 0 || b == 0)
                            {
                                a = rnd.Next(10, 100);
                                b = mul3[rnd.Next(0, 2)];
                            }
                        }

                    }
                    toLabel(label2, $"{a.ToString()} {action} {b.ToString()}", label2.ForeColor);

                    while (end_current_question == false)
                    {
                        Thread.Sleep(1000);
                        if (end_current_question)
                        {
                            if (textBox1.Text != "")
                            {
                                myAns = Convert.ToInt32(textBox1.Text);

                                if (checkAns(myAns, a, b, action, r) == 1)
                                {
                                    toLabel(label6, "OK", Color.Green);
                                    end_current_question = false;
                                    score += 1;
                                }
                                else
                                {
                                    toLabel(label6, "BAD", Color.Red);
                                    end_current_question = false;
                                }
                                break;
                            }

                            else
                            {
                                toLabel(label6, "BAD", Color.Red);
                                end_current_question = false;
                                break;
                            }
                        }
                    }
                    toLabel(label4, "30", label4.ForeColor);
                    a = 1;
                    b = 2;
                }

                else if (dif == "4")
                {
                    c = rnd.Next(0, 4);
                    action = act[c];
                    if (action == "+")
                    {
                        a = rnd.Next(0, 1000);
                        b = rnd.Next(0, 1000);
                        while (a + b > 1000)
                        {
                            a = rnd.Next(0, 1000);
                            b = rnd.Next(0, 1000);
                        }
                    }

                    else if (action == "-")
                    {
                        a = rnd.Next(0, 1000);
                        b = rnd.Next(0, 1000);
                        while (a - b < 0)
                        {
                            a = rnd.Next(0, 1000);
                            b = rnd.Next(0, 1000);
                        }
                    }

                    else if (action == "*")
                    {
                        _tmp = rnd.Next(0, 2);

                        if (_tmp == 0)
                        {
                            a = rnd.Next(0, 10);
                            b = rnd.Next(0, 10);
                        }

                        else
                        {
                            __tmp = rnd.Next(0, 2);
                            if (__tmp == 0)
                            {
                                a = rnd.Next(10, 1000);
                                b = 2;
                            }

                            else
                            {
                                a = rnd.Next(10, 1000);
                                b = 10;
                            }
                        }
                    }

                    else if (action == "/")
                    {
                        _tmp = rnd.Next(0, 2);

                        if (_tmp == 0)
                        {
                            a = div[rnd.Next(0, 37)];
                            b = div[rnd.Next(0, 37)];

                            while (a % b != 0 || a / b > 9 || b > 9)
                            {
                                a = div[rnd.Next(0, 37)];
                                b = div[rnd.Next(0, 37)];
                            }
                        }

                        else
                        {
                            a = rnd.Next(10, 1000);
                            b = mul3[rnd.Next(0, 2)];

                            while (a % b != 0 || b == 0)
                            {
                                a = rnd.Next(10, 1000);
                                b = mul3[rnd.Next(0, 2)];
                            }
                        }

                    }
                    toLabel(label2, $"{a.ToString()} {action} {b.ToString()}", label2.ForeColor);

                    while (end_current_question == false)
                    {
                        Thread.Sleep(1000);
                        if (end_current_question)
                        {
                            if (textBox1.Text != "")
                            {
                                myAns = Convert.ToInt32(textBox1.Text);

                                if (checkAns(myAns, a, b, action, r) == 1)
                                {
                                    toLabel(label6, "OK", Color.Green);
                                    end_current_question = false;
                                    score += 1;
                                }
                                else
                                {
                                    toLabel(label6, "BAD", Color.Red);
                                    end_current_question = false;
                                }
                                break;
                            }

                            else
                            {
                                toLabel(label6, "BAD", Color.Red);
                                end_current_question = false;
                                break;
                            }
                        }
                    }
                    toLabel(label4, "30", label4.ForeColor);
                    a = 1;
                    b = 2;
                }

                else if (dif == "5")
                {
                    c = rnd.Next(0, 6);
                    action = act[c];

                    if (action == "+")
                    {
                        a = rnd.Next(-50, 50);
                        b = rnd.Next(-50, 50);
                    }

                    else if (action == "-")
                    {
                        a = rnd.Next(50, 100);
                        b = rnd.Next(80, 100);
                    }

                    else if (action == "*")
                    {
                        __tmp = rnd.Next(0, 5);
                        a = rnd.Next(10, 10000);
                        b = mul5[__tmp];
                    }

                    else if (action == "/")
                    {
                        a = rnd.Next(10, 10000);
                        b = mul5[rnd.Next(0, 5)];

                        while (a % b != 0 || b == 0)
                        {
                            a = rnd.Next(10, 10000);
                            b = mul5[rnd.Next(0, 5)];
                        }
                    }

                    else if (action == "^")
                    {
                        a = rnd.Next(0, 10);
                        b = rnd.Next(0, 3);
                    }

                    else if (action == "%")
                    {
                        a = rnd.Next(10, 1000);
                        b = per[rnd.Next(0, 9)];

                        while (((a / 100) * b) % 2 != 0 || a % 10 != 0)
                        {
                            a = rnd.Next(10, 1000);
                            b = per[rnd.Next(0, 9)];
                        }
                    }
                    if (action == "%")
                    {
                        toLabel(label2, $"{b.ToString()}% от {a.ToString()}", label2.ForeColor);
                    }

                    else
                    {
                        toLabel(label2, $"{a.ToString()} {action} {b.ToString()}", label2.ForeColor);
                    }

                    while (end_current_question == false)
                    {
                        Thread.Sleep(1000);
                        if (end_current_question)
                        {
                            if (textBox1.Text != "")
                            {
                                myAns = Convert.ToInt32(textBox1.Text);

                                if (checkAns(myAns, a, b, action, r) == 1)
                                {
                                    toLabel(label6, "OK", Color.Green);
                                    end_current_question = false;
                                    score += 1;
                                }
                                else
                                {
                                    toLabel(label6, "BAD", Color.Red);
                                    end_current_question = false;
                                }
                                break;
                            }

                            else
                            {
                                toLabel(label6, "BAD", Color.Red);
                                end_current_question = false;
                                break;
                            }
                        }
                    }
                    toLabel(label4, "30", label4.ForeColor);
                    a = 1;
                    b = 2;
                }

            }

            solutionTimer.Stop();
            timeTimer.Stop();

            Action visAction = () => label9.Visible = true;
            Invoke(visAction);

            visAction = () => visFalse();
            Invoke(visAction);
        }

        int doNothing()
        {
            return 0;
        }

        int checkAns(float myAns, Int32 a, Int32 b, String action, Int32 r)
        {
            if (action == "+")
            {
                if (myAns == (float)(a + b))
                {
                    r = 1;
                }
                
                else
                {
                    r = 0;
                }
            }

            else if (action == "-")
            {
                if (myAns == (float)(a - b))
                {
                    r = 1;
                }

                else
                {
                    r = 0;
                }
            }

            else if (action == "*")
            {
                if (myAns == (float)(a * b))
                {
                    r = 1;
                }

                else
                {
                    r = 0;
                }
            }

            else if (action == "/")
            {
                tmp = a / b;
                if (myAns == Math.Round(tmp, 3))
                {
                    r = 1;
                }

                else
                {
                    r = 0;
                }
            }

            else if (action == "^")
            {
                if (myAns == Math.Pow(a, b))
                {
                    r = 1;
                }

                else
                {
                    r = 0;
                }
            }

            else if (action == "%")
            {
                if (myAns == ((float)a / 100) * b)
                {
                    r = 1;
                }

                else
                {
                    r = 0;
                }
            }
            Action clrBox = () => textBox1.Clear();
            Invoke(clrBox);
            return r;
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            end_current_question = true;
        }

        private void solutionTimer_Tick(object sender, EventArgs e)
        {
            end_current_question = true;
        }

        private void game_Shown(object sender, EventArgs e)
        {
            if (theme == "theme=dark")
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                numsLabel.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
            }

            timeTimer.Enabled = true;
            Thread t = new Thread(timeMethod);
            t.Start();
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }        
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        public game()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("settings.conf");
            theme = sr.ReadLine();
            dif = sr.ReadLine();
            q = sr.ReadLine();
            sr.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (File.Exists("marks"))
            {
                File.AppendAllText("marks", $"{score}/{q}\n");
            }
            
            else
            {
                File.WriteAllText("marks", $"{score}/{q}\n");
            }
            warning w = new warning();
            w.Show();
            this.Visible = false;
            Form1 m = new Form1();
            m.Show();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            if (label4.Text != "0")
            {
                toLabel(label4, (Convert.ToInt32(label4.Text) - 1).ToString(), label4.ForeColor);
            }

            else
            {
                end_current_question = true;
                label6.Text = "BAD";
                label6.ForeColor = Color.Red;
                label4.Text = "30";
            }
            timeTimer.Enabled = true;
        }
    }
}
