using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace DrawSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level1 level1 = new Level1();
            MainForm form = new MainForm();
            level1.Location = new Point(form.Location.X, form.Location.Y);
            level1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go For It\nLogic Stack\n2017", "About", MessageBoxButtons.OK);
        }
    }
}
