using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS
{
    public partial class Form1 : Form
    {

        bool jumping = false;
        int gravity = 5;
        int speed = 5;
        int scoretotal = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            // Transparent Picturebox
            pictureBox1.Controls.Add(bird);
            pictureBox1.Controls.Add(Gameover);
            // Transparent Gameover
            Gameover.Location = new Point(96, 237);
            Gameover.BackColor = Color.Transparent;
            // Transparent Bird
            bird.BackColor = Color.Transparent;
            //restart button transparent
            restartbutton.BackColor = Color.Transparent;


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = 15;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = -15;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pipedown.Left -= speed;
            pipeup.Left -= speed;
            pipedown2.Left -= speed;
            pipeup2.Left -= speed;
            pipedown3.Left -= speed;
            pipeup3.Left -= speed;
            pipedown4.Left -= speed;
            pipeup4.Left -= speed;
            bird.Top += gravity;

            label1.Text = scoretotal.ToString();


            if (pipedown.Left < -80)
            {
                pipedown.Left = 500;

            }
            else if (pipeup.Left < -80)
            {
                pipeup.Left = 500;
                scoretotal++;
            }
            //Pipe 2
            else if (pipedown2.Left < -80)
            {
                pipedown2.Left = 500;

            }
            else if (pipeup2.Left < -80)
            {
                pipeup2.Left = 500;
                scoretotal++;
            }
            //Pipe 3
            else if (pipedown3.Left < -80)
            {
                pipedown3.Left = 500;

            }
            else if (pipeup3.Left < -80)
            {
                pipeup3.Left = 500;
                scoretotal++;
            }
            //Pipe 4
            else if (pipedown4.Left < -80)
            {
                pipedown4.Left = 500;

            }
            else if (pipeup4.Left < -80)
            {
                pipeup4.Left = 500;
                scoretotal++;
            }

            // kalo nabrak pipe 1
            if (bird.Bounds.IntersectsWith(pipeup.Bounds))
            {
                Gameovers();
            }
            else if (bird.Bounds.IntersectsWith(pipedown.Bounds))
            {
                Gameovers();
            }
            // kalo nabrak pipe 2
            else if (bird.Bounds.IntersectsWith(pipeup2.Bounds))
            {
                Gameovers();
            }
            else if (bird.Bounds.IntersectsWith(pipedown2.Bounds))
            {
                Gameovers();
            }
            // kalo nabrak pipe 3
            else if (bird.Bounds.IntersectsWith(pipeup3.Bounds))
            {
                Gameovers();
            }
            else if (bird.Bounds.IntersectsWith(pipedown3.Bounds))
            {
                Gameovers();
            }
            // kalo nabrak pipe 4
            else if (bird.Bounds.IntersectsWith(pipeup4.Bounds))
            {
                Gameovers();
            }
            else if (bird.Bounds.IntersectsWith(pipedown4.Bounds))
            {
                Gameovers();
            }
            // kalo nabrak ground
            else if (bird.Bounds.IntersectsWith(ground.Bounds))
            {
                Gameovers();
            }
        }

        public void Gameovers()
        {
            Gameover.Visible = true;
            timer1.Stop();
            restartbutton.Visible = true;

        }

        private void restartbutton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
