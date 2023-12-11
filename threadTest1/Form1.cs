using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadTest1
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        bool run = false;
        int time = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 0; b = 0;
            progressBar1.Value = a;
            progressBar2.Value = b;
            run = true;
            timer();
        }
        private void timer()
        {
            while (run)
            {
                time++;
                if (time % 1 == 0 && a < 100) a++;
                if (time % 5 == 0 && b < 100) b++;  
                progressBar1.Value = a;
                progressBar2.Value = b;
                if (b == 100) {run = false; }
                if(time == 5)time = 0;
                Thread.Sleep(1);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            a = 0;b = 0;
            progressBar1.Value = a;
            progressBar2.Value = b;
            label1.Text = a.ToString();
            label2.Text = b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            run = false;
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
