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

namespace testThread2
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        bool run = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            run = true;
            progressBar1.Value = a;
            progressBar2.Value = b;
            count1();
            count2();
        }

        private async void count1() { 
            while (run) {
                if (a < 100)
                    a++;
                else return;
                progressBar1.Value = a; 
                label1.Text = a.ToString();
                await Task.Delay(20);
            }
        }
        private async void count2()
        {
            while (run)
            {
                if (b < 100)
                    b++;
                else return;
                progressBar2.Value = b;
                label2.Text = b.ToString();
                await Task.Delay(100);

            }
        }
    }
}
