namespace DrawSharp
{
    partial class Level2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.Vvod = new System.Windows.Forms.TextBox();
            this.OneWord = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.trueA = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.falseA = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.PictureBox();
            this.enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OneWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vvod.Location = new System.Drawing.Point(175, 292);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(335, 44);
            this.Vvod.TabIndex = 14;
            // 
            // OneWord
            // 
            this.OneWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneWord.BackColor = System.Drawing.Color.Transparent;
            this.OneWord.Image = ((System.Drawing.Image)(resources.GetObject("OneWord.Image")));
            this.OneWord.Location = new System.Drawing.Point(65, 166);
            this.OneWord.Name = "OneWord";
            this.OneWord.Size = new System.Drawing.Size(554, 99);
            this.OneWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OneWord.TabIndex = 13;
            this.OneWord.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(575, 383);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 100);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 12;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.help.Location = new System.Drawing.Point(12, 383);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(100, 100);
            this.help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.help.TabIndex = 11;
            this.help.TabStop = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(142, -10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(400, 170);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // trueA
            // 
            this.trueA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.trueA.Image = ((System.Drawing.Image)(resources.GetObject("trueA.Image")));
            this.trueA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trueA.Location = new System.Drawing.Point(272, 181);
            this.trueA.Name = "trueA";
            this.trueA.Size = new System.Drawing.Size(140, 130);
            this.trueA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trueA.TabIndex = 16;
            this.trueA.TabStop = false;
            this.trueA.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // falseA
            // 
            this.falseA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.falseA.Image = ((System.Drawing.Image)(resources.GetObject("falseA.Image")));
            this.falseA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.falseA.Location = new System.Drawing.Point(272, 181);
            this.falseA.Name = "falseA";
            this.falseA.Size = new System.Drawing.Size(140, 130);
            this.falseA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.falseA.TabIndex = 17;
            this.falseA.TabStop = false;
            this.falseA.Visible = false;
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.next.Location = new System.Drawing.Point(257, 373);
            this.next.Margin = new System.Windows.Forms.Padding(0);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(170, 114);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 18;
            this.next.TabStop = false;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter.BackgroundImage")));
            this.enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enter.Location = new System.Drawing.Point(516, 292);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(44, 44);
            this.enter.TabIndex = 19;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(272, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Составьте слово";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // menu
            // 
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menu.Location = new System.Drawing.Point(12, 12);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(153, 70);
            this.menu.TabIndex = 39;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Level2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 492);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.falseA);
            this.Controls.Add(this.trueA);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.OneWord);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Level2";
            this.Text = "Level2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.OneWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox help;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox OneWord;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.PictureBox trueA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox falseA;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menu;
    }
}