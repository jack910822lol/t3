using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t2
{
    public partial class Form1 : Form
    {
        int v = 0; 
        double t=0 ;
        static int a = 15;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t+=0.1;
            v += (int)(a * t);
            ball.Top += v; 
            if(ball.Bottom >= this.Height)
            {
                ball.Top = this.Height - ball.Height;
                v = -v;
            }
        }
    }
}
