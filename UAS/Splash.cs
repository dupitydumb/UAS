using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UAS
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox2);

            pictureBox2.BackColor = Color.Transparent;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            timer1.Stop();
            this.Hide();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
    }
}
