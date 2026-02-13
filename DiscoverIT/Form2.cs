using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;

namespace DiscoverIT
{
    public partial class Form2 : Form
    {
        int x = 0;
        string color = DiscoverIT.Properties.Settings.Default.ColorMode;
        int france = 0;
        int turkey = 0;
        int italy = 0;
        int romania = 0;
        int spain = 0;
        int UnitedKingdomofGreatBritainANDNorthernIreland = 0;
        

        public bool IsConnectedToInternet()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Form2()
        {
            InitializeComponent();

            if (IsConnectedToInternet() == true)
            {
                
            }
            else
            {
                MessageBox.Show("We've detected that you do not have a internet connection. We highly recommend using DiscoverIT in Offline Mode if you want to view more of each country!");
            }
            
            
            if (color == "1")
                this.BackColor = Color.FromArgb(27, 27, 27);
                pictureBox2.Image = DiscoverIT.Properties.Resources.moon_4_32;



            label1.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            label1.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel5.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel6.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel7.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel8.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel9.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel10.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel11.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel12.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel13.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel14.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel15.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel17.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel18.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuLabel19.ForeColor = Color.FromArgb(255, 255, 255);
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel2.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel3.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel4.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel5.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel6.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel7.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel8.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel9.LinkColor = Color.FromArgb(128, 128, 255);
            this.BackColor = Color.FromArgb(27, 27, 27);

            if (color == "0")
                this.BackColor = Color.FromArgb(255, 255, 255);
                pictureBox2.Image = DiscoverIT.Properties.Resources.sun_32;



            label1.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel2.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel1.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel3.ForeColor = Color.FromArgb(0, 0, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel5.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel6.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel7.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel8.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel9.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel10.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel11.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel12.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel13.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel14.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel15.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel17.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel18.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuLabel19.ForeColor = Color.FromArgb(0, 0, 0);
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 255);
            linkLabel2.LinkColor = Color.FromArgb(0, 0, 255);
            linkLabel3.LinkColor = Color.FromArgb(0, 0, 255);
            linkLabel4.LinkColor = Color.FromArgb(0, 0, 255);
            linkLabel5.LinkColor = Color.FromArgb(0, 0, 255);
            linkLabel6.LinkColor = Color.FromArgb(0, 0, 255);
            linkLabel7.LinkColor = Color.FromArgb(0, 0, 255);
            linkLabel8.LinkColor = Color.FromArgb(0, 0, 255);
            linkLabel9.LinkColor = Color.FromArgb(0, 0, 255);
            this.BackColor = Color.FromArgb(255, 255, 255);

        }

        

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                panel1.BackColor = Color.FromArgb(27, 27, 27);
                while (panel1.Height < 465)
                {
                    panel1.Height++;
                }

                if (panel1.Height > 463)
                {
                    //color changeeeee
                    label1.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel2.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel1.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel3.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel4.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel5.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel6.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel7.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel8.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel9.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel10.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel11.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel12.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel13.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel14.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel15.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel17.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel18.ForeColor = Color.FromArgb(255, 255, 255);
                    bunifuLabel19.ForeColor = Color.FromArgb(255, 255, 255);
                    linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel2.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel3.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel4.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel5.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel6.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel7.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel8.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel9.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel10.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel11.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel12.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel13.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel14.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel15.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel16.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel17.LinkColor = Color.FromArgb(128, 128, 255);
                    linkLabel18.LinkColor = Color.FromArgb(128, 128, 255);
                    
                    this.BackColor = Color.FromArgb(27, 27, 27);
                    pictureBox2.Image = DiscoverIT.Properties.Resources.moon_4_32;

                    Task.Delay(1000);
                    if (panel1.Height > 463)
                        {
                            panel1.Height = 465;
                            while (panel1.Height > 29)
                            {
                                panel1.Height--;
                            }
                        }
                    




                //Moon
                
                x = 1;
                Task.Delay(1000);
                
                DiscoverIT.Properties.Settings.Default.ColorMode = "1";
                DiscoverIT.Properties.Settings.Default.Save();
                }
                
            }
            else if(x == 1)
            {
                panel1.BackColor = Color.FromArgb(255, 255, 255);
                while (panel1.Height < 465)
                {
                    panel1.Height++;
                }

                if (panel1.Height > 463)
                {
                    //color changeeeee
                    label1.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel2.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel1.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel3.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel4.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel5.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel6.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel7.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel8.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel9.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel10.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel11.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel12.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel13.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel14.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel15.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel17.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel18.ForeColor = Color.FromArgb(0, 0, 0);
                    bunifuLabel19.ForeColor = Color.FromArgb(0, 0, 0);
                    linkLabel1.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel2.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel3.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel4.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel5.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel6.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel7.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel8.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel9.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel10.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel11.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel12.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel13.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel14.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel15.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel16.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel17.LinkColor = Color.FromArgb(0, 0, 255);
                    linkLabel18.LinkColor = Color.FromArgb(0, 0, 255);
                    this.BackColor = Color.FromArgb(255, 255, 255);
                    pictureBox2.Image = DiscoverIT.Properties.Resources.sun_32;

                    Task.Delay(1000);
                    if (panel1.Height > 463)
                    {
                        panel1.Height = 465;
                        while (panel1.Height > 29)
                        {
                            panel1.Height--;
                        }
                    }
                }





                    //Sun
                    
                x = 0;
                Task.Delay(1000);
                
                DiscoverIT.Properties.Settings.Default.ColorMode = "0";
                DiscoverIT.Properties.Settings.Default.Save();
            }    

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (france == 0)
            {
                //show text n stuff
                bunifuLabel12.Location = new Point(7, 201);
                bunifuLabel12.Visible = true;
                linkLabel1.Location = new Point(4, 297);
                linkLabel2.Location = new Point(49, 297);
                linkLabel3.Location = new Point(119, 297);
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
                linkLabel3.Visible = true;


                //hide shit
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                bunifuLabel3.Visible = false;
                label1.Visible = false;
                bunifuLabel5.Visible = false;
                bunifuLabel6.Visible = false;
                bunifuLabel7.Visible = false;
                bunifuLabel8.Visible = false;
                bunifuLabel9.Visible = false;
                bunifuLabel10.Visible = false;
                bunifuLabel11.Visible = false;
                france += 1;
            }

            else if(france == 1)
            {
                //show shit
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                bunifuLabel3.Visible = true;
                label1.Visible = true;
                bunifuLabel5.Visible = true;
                bunifuLabel6.Visible = true;
                bunifuLabel7.Visible = true;
                bunifuLabel8.Visible = true;
                bunifuLabel9.Visible = true;
                bunifuLabel10.Visible = true;
                bunifuLabel11.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                bunifuLabel12.Visible = false;
                france -= 1;
            }

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (romania == 0)
            {
                //show text n stuff
                pictureBox4.Location = new Point(7, 94);
                bunifuLabel1.Text = "Romania";
                bunifuLabel15.Location = new Point(7, 201);
                bunifuLabel15.Visible = true;
                linkLabel10.Visible = true;
                linkLabel11.Visible = true;
                linkLabel12.Visible = true;
                linkLabel10.Location = new Point(4, 323);
                linkLabel11.Location = new Point(49, 323);
                linkLabel12.Location = new Point(119, 323);

                //hide shit
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                bunifuLabel3.Visible = false;
                label1.Visible = false;
                bunifuLabel5.Visible = false;
                bunifuLabel6.Visible = false;
                bunifuLabel7.Visible = false;
                bunifuLabel8.Visible = false;
                bunifuLabel9.Visible = false;
                bunifuLabel10.Visible = false;
                bunifuLabel11.Visible = false;
                romania += 1;
            }

            else if (romania == 1)
            {
                //show shit
                linkLabel10.Visible = false;
                linkLabel11.Visible = false;
                linkLabel12.Visible = false;
                bunifuLabel15.Visible = false;
                pictureBox4.Location = new Point(267, 257);
                bunifuLabel1.Text = "France";
                pictureBox1.Visible = true;
                pictureBox1.Enabled = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                bunifuLabel3.Visible = true;
                label1.Visible = true;
                bunifuLabel5.Visible = true;
                bunifuLabel6.Visible = true;
                bunifuLabel7.Visible = true;
                bunifuLabel8.Visible = true;
                bunifuLabel9.Visible = true;
                bunifuLabel10.Visible = true;
                bunifuLabel11.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                bunifuLabel12.Visible = false;
                romania -= 1;
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (spain == 0)
            {
                //show text n stuff
                bunifuLabel4.Location = new Point(7, 193);
                bunifuLabel4.Visible = true;
                linkLabel13.Location = new Point(4, 263);
                linkLabel14.Location = new Point(49, 263);
                linkLabel15.Location = new Point(119, 263);
                linkLabel13.Visible = true;
                linkLabel14.Visible = true;
                linkLabel15.Visible = true;
                pictureBox5.Location = new Point(7, 94);
                bunifuLabel1.Text = "Spain";



                //hide shit
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                bunifuLabel3.Visible = false;
                label1.Visible = false;
                bunifuLabel5.Visible = false;
                bunifuLabel6.Visible = false;
                bunifuLabel7.Visible = false;
                bunifuLabel8.Visible = false;
                bunifuLabel9.Visible = false;
                bunifuLabel10.Visible = false;
                bunifuLabel11.Visible = false;
                spain += 1;
            }

            else if (spain == 1)
            {
                //show shit
                linkLabel13.Visible = false;
                linkLabel14.Visible = false;
                linkLabel15.Visible = false;
                bunifuLabel4.Visible = false;
                bunifuLabel1.Text = "France";
                pictureBox1.Visible = true;
                pictureBox1.Enabled = true;
                pictureBox5.Location = new Point(267, 94);
                pictureBox4.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                bunifuLabel3.Visible = true;
                label1.Visible = true;
                bunifuLabel5.Visible = true;
                bunifuLabel6.Visible = true;
                bunifuLabel7.Visible = true;
                bunifuLabel8.Visible = true;
                bunifuLabel9.Visible = true;
                bunifuLabel10.Visible = true;
                bunifuLabel11.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                bunifuLabel12.Visible = false;
                spain -= 1;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (italy == 0)
            {
                //show text n stuff
                pictureBox6.Location = new Point(7, 94);
                bunifuLabel14.Location = new Point(7, 201);
                linkLabel8.Location = new Point(4, 323);
                linkLabel7.Location = new Point(49, 323);
                linkLabel9.Location = new Point(119, 323);
                linkLabel8.Visible = true;
                linkLabel7.Visible = true;
                linkLabel9.Visible = true;
                bunifuLabel14.Visible = true;
                bunifuLabel1.Text = "Italy";
                bunifuLabel1.Location = new Point(57, 180);


                //hide shit
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                bunifuLabel3.Visible = false;
                label1.Visible = false;
                bunifuLabel5.Visible = false;
                bunifuLabel6.Visible = false;
                bunifuLabel7.Visible = false;
                bunifuLabel8.Visible = false;
                bunifuLabel9.Visible = false;
                bunifuLabel10.Visible = false;
                bunifuLabel11.Visible = false;
                italy += 1;
            }

            else if (italy == 1)
            {
                //show shit
                bunifuLabel1.Text = "France";
                bunifuLabel1.Location = new Point(52, 180);
                bunifuLabel14.Visible = false;
                linkLabel8.Visible = false;
                linkLabel7.Visible = false;
                linkLabel9.Visible = false;
                pictureBox1.Visible = true;
                pictureBox1.Enabled = true;
                pictureBox6.Location = new Point(527, 94);
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                bunifuLabel3.Visible = true;
                label1.Visible = true;
                bunifuLabel5.Visible = true;
                bunifuLabel6.Visible = true;
                bunifuLabel7.Visible = true;
                bunifuLabel8.Visible = true;
                bunifuLabel9.Visible = true;
                bunifuLabel10.Visible = true;
                bunifuLabel11.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                bunifuLabel12.Visible = false;
                italy -= 1;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (turkey == 0)
            {
                //show text n stuff
                bunifuLabel13.Location = new Point(7, 201);
                bunifuLabel13.Visible = true;
                pictureBox7.Location = new Point(7, 94);
                linkLabel4.Visible = true;
                linkLabel5.Visible = true;
                linkLabel6.Visible = true;
                linkLabel4.Location = new Point(4, 310);
                linkLabel5.Location = new Point(49, 310);
                linkLabel6.Location = new Point(119, 310);

                bunifuLabel1.Text = "Turkey";


                //hide shit
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                bunifuLabel3.Visible = false;
                label1.Visible = false;
                bunifuLabel5.Visible = false;
                bunifuLabel6.Visible = false;
                bunifuLabel7.Visible = false;
                bunifuLabel8.Visible = false;
                bunifuLabel9.Visible = false;
                bunifuLabel10.Visible = false;
                bunifuLabel11.Visible = false;
                turkey += 1;
            }

            else if (turkey == 1)
            {
                //show shit
                linkLabel4.Visible = false;
                linkLabel5.Visible = false;
                linkLabel6.Visible = false;
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox7.Location = new Point(7, 257);
                bunifuLabel1.Text = "France";
                bunifuLabel13.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                bunifuLabel3.Visible = true;
                label1.Visible = true;
                bunifuLabel5.Visible = true;
                bunifuLabel6.Visible = true;
                bunifuLabel7.Visible = true;
                bunifuLabel8.Visible = true;
                bunifuLabel9.Visible = true;
                bunifuLabel10.Visible = true;
                bunifuLabel11.Visible = true;

                turkey -= 1;
            }
            
        }

        /*
         *      if (france == 0)
            {
                //show text n stuff
                bunifuLabel12.Location = new Point(7, 180);
                bunifuLabel12.Visible = true;
                linkLabel1.Location = new Point(4, 289);
                linkLabel2.Location = new Point(49, 289);
                linkLabel3.Location = new Point(119, 289);
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
                linkLabel3.Visible = true;


                //hide shit
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                bunifuLabel3.Visible = false;
                label1.Visible = false;
                bunifuLabel5.Visible = false;
                bunifuLabel6.Visible = false;
                bunifuLabel7.Visible = false;
                bunifuLabel8.Visible = false;
                bunifuLabel9.Visible = false;
                bunifuLabel10.Visible = false;
                bunifuLabel11.Visible = false;
                france += 1;
            }

            else if(france == 1)
            {
                //show shit
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                bunifuLabel3.Visible = true;
                label1.Visible = true;
                bunifuLabel5.Visible = true;
                bunifuLabel6.Visible = true;
                bunifuLabel7.Visible = true;
                bunifuLabel8.Visible = true;
                bunifuLabel9.Visible = true;
                bunifuLabel10.Visible = true;
                bunifuLabel11.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                bunifuLabel12.Visible = false;
                france -= 1;
            }
        */
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (UnitedKingdomofGreatBritainANDNorthernIreland == 0)
            {
                //show text n stuff
                pictureBox8.Location = new Point(7, 94);
                bunifuLabel19.Location = new Point(7, 180);
                bunifuLabel19.Visible = true;
                linkLabel17.Visible = true;
                linkLabel18.Visible = true;
                linkLabel16.Visible = true;
                linkLabel16.Location = new Point(4, 289);
                linkLabel17.Location = new Point(49, 289);
                linkLabel18.Location = new Point(119, 289);
                bunifuLabel6.Location = new Point(137, 102);
                bunifuLabel10.Location = new Point(169, 115);
                bunifuLabel9.Location = new Point(145, 129);
                bunifuLabel8.Location = new Point(164, 141);
                bunifuLabel7.Location = new Point(136, 153);



                //hide shit
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                bunifuLabel3.Visible = false;
                label1.Visible = false;
                bunifuLabel5.Visible = false;
                bunifuLabel11.Visible = false;
                UnitedKingdomofGreatBritainANDNorthernIreland += 1;
            }

            else if (UnitedKingdomofGreatBritainANDNorthernIreland == 1)
            {
                //show shit
                pictureBox8.Location = new Point(527, 257);
                linkLabel17.Visible = false;
                linkLabel18.Visible = false;
                linkLabel16.Visible = false;
                bunifuLabel6.Location = new Point(551, 343);
                bunifuLabel10.Location = new Point(583, 356);
                bunifuLabel9.Location = new Point(559, 370);
                bunifuLabel8.Location = new Point(578, 382);
                bunifuLabel7.Location = new Point(550, 394);
                bunifuLabel19.Visible = false;

                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                bunifuLabel3.Visible = true;
                label1.Visible = true;
                bunifuLabel5.Visible = true;
                bunifuLabel11.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                bunifuLabel12.Visible = false;
                UnitedKingdomofGreatBritainANDNorthernIreland -= 1;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://snippetsofparis.com/french-writers/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/French_architecture");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/History_of_France");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://becomeawritertoday.com/best-turkish-authors/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/History_of_Turkey");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.allaboutturkey.com/architecture.html");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/Architecture_of_Italy");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://becomeawritertoday.com/best-italian-authors/");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/History_of_Italy");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.uncover-romania.com/about-romania/romanian-people/romanian-authors/amp/");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/Romanian_architecture");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/History_of_Romania");
        }

        private void bunifuLabel18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 nyah = new Form3();
            nyah.ShowDialog();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.oprahdaily.com/entertainment/books/g28186051/spanish-authors/");
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/Spanish_architecture");
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/History_of_Spain");
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.m.wikipedia.org/wiki/Architecture_of_the_United_Kingdom");
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.britain-magazine.com/features/britains-top-ten-british-writers/");
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.britain-magazine.com/features/britains-top-ten-british-writers/v");
        }
    }
}
