using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawSharp
{
    public partial class Level4 : Form
    {
        public Level4()
        {
            InitializeComponent();        
        }

        bool ck_3215 = false, ck_95 = false, ck_4 = false, ck_7 = false;

        private void n_3215_Click(object sender, EventArgs e)
        {
            ck_3215 = true;
            numbers1.Text += "3215\n";
            numbers2.Text += "3215\n";
            n_3215.Visible = false;
        }

        private void n_95_Click(object sender, EventArgs e)
        {
            if (ck_3215 == true) { ck_95 = true; numbers1.Text += "95\n"; numbers2.Text += "95\n"; n_95.Visible = false; }
            else {
                    falseA.Visible = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                    ck_3215 = false; ck_95 = false; ck_4 = false;  ck_7 = false; numbers1.Text = ""; numbers2.Text = "";
                    n_3215.Visible = true;
            }
        }

        private void num_4_Click(object sender, EventArgs e)
        {
            if ((ck_3215 == true) && (ck_95 == true)) { ck_4 = true; numbers1.Text += "4\n"; numbers2.Text += "4\n"; num_4.Visible = false; }
            else
            {
                falseA.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                ck_3215 = false; ck_95 = false; ck_4 = false; ck_7 = false; numbers1.Text = ""; numbers2.Text = "";
                n_3215.Visible = true;
                n_95.Visible = true;
            }
        }

        private void n_7_Click(object sender, EventArgs e)
        {
            if ((ck_3215 == true) && (ck_95 == true) && (ck_4 == true)) { ck_7 = true; numbers1.Text += "-7\n"; numbers2.Text += "-7\n"; n_7.Visible = false; }
            else
            {
                falseA.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                ck_3215 = false; ck_95 = false; ck_4 = false; ck_7 = false; numbers1.Text = ""; numbers2.Text = "";
                n_3215.Visible = true;
                n_95.Visible = true;
                num_4.Visible = true;
            }
        }

        private void n_196_Click(object sender, EventArgs e)
        {
            if ((ck_3215 == true) && (ck_95 == true) && (ck_4 == true) && (ck_7 == true))
            {
                numbers1.Text += "-196";
                numbers2.Text += "-196";
                n_196.Visible = false;
                next.Visible = true;  }
            else
            {
                falseA.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                ck_3215 = false; ck_95 = false; ck_4 = false; ck_7 = false; numbers1.Text = ""; numbers2.Text = "";
                n_3215.Visible = true;
                n_95.Visible = true;
                num_4.Visible = true;
                n_7.Visible = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите все числа в порядке убывания", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();
            menu.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            falseA.Visible = false;
            timer1.Stop();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Level5 level5 = new Level5();
            level5.Show();
            Hide();
        }

        private void Level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (e.CloseReason != CloseReason.UserClosing) return;
            result = MessageBox.Show("Вы действительно хотите выйти ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes) { Application.Exit(); }
            else e.Cancel = true;
        }
    }
}
