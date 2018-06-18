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
    public partial class Level3 : Form
    {
        public Level3()
        {
            InitializeComponent();
        }

        int done = 0;
        private void next_Click(object sender, EventArgs e)
        {
            Level4 level4 = new Level4();
            level4.Show();
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Соберите все яблоки на экране", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Level3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (e.CloseReason != CloseReason.UserClosing) return;
            result = MessageBox.Show("Вы действительно хотите выйти ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes) { Application.Exit(); }
            else e.Cancel = true;
        }

        private void apple1_Click(object sender, EventArgs e)
        {
            apple1.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }

        private void apple2_Click(object sender, EventArgs e)
        {
            apple2.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }
        private void apple3_Click(object sender, EventArgs e)
        {
            apple3.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }
        private void apple4_Click(object sender, EventArgs e)
        {
            apple4.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }
        private void apple5_Click(object sender, EventArgs e)
        {
            apple5.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }
        private void apple6_Click(object sender, EventArgs e)
        {
            apple6.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }
        private void apple7_Click(object sender, EventArgs e)
        {
            apple7.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }
        private void apple8_Click(object sender, EventArgs e)
        {
            apple8.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }
        private void apple9_Click(object sender, EventArgs e)
        {
            apple9.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }
        private void apple10_Click(object sender, EventArgs e)
        {
            apple10.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }
        private void apple11_Click(object sender, EventArgs e)
        {
            apple11.Visible = false;
            done++;
            if (done == 11) next.Visible = true;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();
            menu.Show();
            Hide();
        }
    }
}
