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
    public partial class Level5 : Form
    {
        public Level5()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            string answer;
            answer = Convert.ToString(Vvod.Text);
            if ((answer == "Ч") || (answer == "ч"))
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            trueA.Visible = false;
            falseA.Visible = false;
            timer1.Stop();
        }

        private void next_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();
            menu.Show();
            Hide();
            MessageBox.Show("More levels soon!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Воспользуйтесь сложением и вычитанием", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Level1_FormClosing(object sender, FormClosingEventArgs e)
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
