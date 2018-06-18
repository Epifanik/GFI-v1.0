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
    public partial class Level2 : Form
    {
        public Level2()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Level3 level3 = new Level3();
            level3.Show();
            Hide();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Составьте одно слово из приведенного набора букв", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "Составьте одно слово";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            trueA.Visible = false;
            falseA.Visible = false;
            timer1.Stop();
        }        

        private void enter_Click(object sender, EventArgs e)
        {
            string answer;
            string key = "одно слово";
            answer = Convert.ToString(Vvod.Text);
            if (answer == key)
            {
                trueA.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                next.Visible = true;
            }
            else
            {
                falseA.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
                Vvod.Text = "";
            }
        }

        private void Level2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (e.CloseReason != CloseReason.UserClosing) return;
            result = MessageBox.Show("Вы действительно хотите выйти ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes) { Application.Exit(); }
            else e.Cancel = true;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();
            menu.Show();
            Hide();
        }
    }
}
