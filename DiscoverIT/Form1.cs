using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscoverIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string x = "Loading, please wait (0/3)";
        string y = "Loading, please wait. (0/3)";
        string z = "Loading, please wait.. (0/3)";
        string w = "Loading, please wait... (0/3)";


        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            WebClient wc = new WebClient();
            string response = wc.DownloadString("https://pastebin.com/raw/Vp6UwW4T");
            if (response == "enabled")
            {

                timer1.Start();
                timer8.Start();
            }
            else if (response == "disabled")
            {
                textBox1.Visible = true;
                label2.Text = "DiscoverIT has been disabled by: admin . Please enter password to bypass checks.";
                timer12.Start();
            }

        }
        private void timer10_Tick(object sender, EventArgs e)
        {
            label2.Text = "Thank you for verifying your identity, admin.";
            timer10.Stop();
            timer11.Start();
        }
        private void timer11_Tick(object sender, EventArgs e)
        {
            label2.Text = "SUCCESSFULLY BYPASSED CHECKS, PROCEEDING...";
            timer11.Stop();
            timer1.Start();
            timer8.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = x;
            timer1.Stop();
            
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label1.Text = y;
            timer5.Stop();
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label1.Text = z;
            timer6.Stop();
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            label1.Text = w;
            timer7.Stop();
            timer1.Start();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            timer8.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            
                x = "Loading, please wait (1/3)";
            
                y = "Loading, please wait. (1/3)";
            
                z = "Loading, please wait.. (1/3)";
            
                w = "Loading, please wait... (1/3)";

            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            
                x = "Loading, please wait (2/3)";
            
                y = "Loading, please wait. (2/3)";
            
                z = "Loading, please wait.. (2/3)";
           
                w = "Loading, please wait... (2/3)";

            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
           
                x = "Welcome to DiscoverIT! (3/3)";
            
                y = "Welcome to DiscoverIT! (3/3)";
            
                z = "Welcome to DiscoverIT! (3/3)";
            
                w = "Welcome to DiscoverIT! (3/3)";

            timer9.Start();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            timer9.Stop();
            this.Hide();
            Form2 meow = new Form2();
            meow.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == "SELENITY")
            {
                timer12.Stop();
                timer10.Start();
            }
        }
    }
}
