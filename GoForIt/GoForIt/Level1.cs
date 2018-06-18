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
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();
        }

        int geom = 0, done = 0;

        private void Geom1_Click(object sender, EventArgs e)
        {
            geom = 0;
            this.Geom1.Size = new System.Drawing.Size(100, 100); // увеличение фигуры при выборе
            Geom2.Size = new System.Drawing.Size(95, 95);
            Geom3.Size = new System.Drawing.Size(95, 95);
            geom++;
        }
        private void Geom2_Click(object sender, EventArgs e)
        {
            geom = 0;
            this.Geom2.Size = new System.Drawing.Size(100, 100);
            Geom1.Size = new System.Drawing.Size(95, 95);
            Geom3.Size = new System.Drawing.Size(95, 95);
            geom += 2;
        }
        private void Geom3_Click(object sender, EventArgs e)
        {
            geom = 0;
            this.Geom3.Size = new System.Drawing.Size(100, 100);
            Geom1.Size = new System.Drawing.Size(95, 95);
            Geom2.Size = new System.Drawing.Size(95, 95);
            geom += 3;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            Geom1.Size = new System.Drawing.Size(95, 95);  // уменьшение фигур при нажатие в стороне
            Geom2.Size = new System.Drawing.Size(95, 95);
            Geom3.Size = new System.Drawing.Size(95, 95);
            geom = 0;               // сброс выбора
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Расставьте фигуры в подходящие по цвету и форме места", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Shape1_Click(object sender, EventArgs e)  // выбор формы квадрата
        {
            switch (geom)
            {
                case 1:
                    Geom1.Controls.Add(Shape1);          
                    Geom1.Location = new Point(436, 192);  // все координаты четко подсчитаны НЕ ЛОМАТЬ
                    Geom1.BackColor = Color.Transparent;    
                    trueA.Visible = true;                  
                    timer1.Interval = 500;
                    timer1.Start();
                    done++;
                    if (done == 3) { next.Visible = true; }
                    break;
                case 2:
                    falseA.Visible = true;      
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
                case 3:
                    falseA.Visible = true;
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
                default:
                    return;
            }
        }

        private void Shape2_Click(object sender, EventArgs e)  
        {
            switch (geom)
            {
                case 1:
                    falseA.Visible = true;
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
                case 2:
                    Geom2.Controls.Add(Shape2);
                    Geom2.Location = new Point(150, 192);   // все координаты четко подсчитаны НЕ ЛОМАТЬ
                    Geom2.BackColor = Color.Transparent;
                    trueA.Visible = true;
                    timer1.Interval = 500;
                    timer1.Start();
                    done++;
                    if (done == 3) { next.Visible = true; }
                    break;
                case 3:
                    falseA.Visible = true;
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
                default:
                    return;
            }
        }

        private void Shape3_Click(object sender, EventArgs e)   
        {
            switch (geom)
            {
                case 1:
                    falseA.Visible = true;
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
                case 2:
                    falseA.Visible = true;
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
                case 3:
                    Geom3.Controls.Add(Shape3);
                    Geom3.Location = new Point(297, 192);   // все координаты четко подсчитаны НЕ ЛОМАТЬ
                    Geom3.BackColor = Color.Transparent;
                    trueA.Visible = true;
                    timer1.Interval = 500;
                    timer1.Start();
                    done++;
                    if (done == 3) { next.Visible = true; }
                    break;
                default:
                    return;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            trueA.Visible = false;
            falseA.Visible = false;
            timer1.Stop();
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            Level2 level2 = new Level2();
            level2.Show();
            Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();
            menu.Show();
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
