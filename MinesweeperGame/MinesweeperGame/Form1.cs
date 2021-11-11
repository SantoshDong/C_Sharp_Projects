using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            StartGame.Enabled = false;
            Random rnd = new Random();
            for(int i = 1; i <= 100; i++)
            {
                Button BtnNumber = new Button();
                int min1 = rnd.Next(1, 15);
                int min2 = rnd.Next(16, 30);
                int min3 = rnd.Next(31, 45);
                int min4 = rnd.Next(45, 60);
                int min5 = rnd.Next(61, 75);
                int min6 = rnd.Next(76, 100);
                BtnNumber.Name = "BtnNumber" + i.ToString();
                BtnNumber.Size = new System.Drawing.Size(40, 40);
                //BtnNumber.TabIndex = 0;
                BtnNumber.Text = i.ToString();
                BtnNumber.UseVisualStyleBackColor = true;
                if(min1 == i || min2 == i || min3 == i || min4 == i || min5 == i || min6 ==i)
                {
                    BtnNumber.Tag = true;
                }
                else
                {
                    BtnNumber.Tag = false;
                }
                BtnNumber.Click += BtnNumber_Click;
                flowLayoutPanel1.Controls.Add(BtnNumber);
            }
        }
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Button BtnNumber = (Button)sender;
            bool tag = (bool)BtnNumber.Tag;
            if (tag)
            { 
                BtnNumber.BackColor = Color.Red;
                int boom = int.Parse(lblBoom.Text);
                boom++;
                lblBoom.Text = boom.ToString();
                BtnNumber.Enabled = false;
                if(boom >= 1)
                {
                    MessageBox.Show("Bomb Explode", "Game Result", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                BtnNumber.BackColor = Color.Green;
                int score = int.Parse(lblScore.Text);
                score++;
                lblScore.Text = score.ToString();
                BtnNumber.Enabled = false;
            }
        }

    }
}
