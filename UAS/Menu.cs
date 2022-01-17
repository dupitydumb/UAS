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
    public partial class Menu : Form
    {
        int groundspeed = 10;

        public Menu()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox5.Left -= groundspeed;

            if (pictureBox5.Left < -100)
            {
                pictureBox5.Left = -15;
            }
        }
    }
}
