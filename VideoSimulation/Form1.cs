using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSimulation
{
    public partial class Form1 : Form
    {
        IOperate function;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "VIDEO";
            label2.Text = "DVD";
            label3.Text = "BLUERAY";
            label4.Text = "Not playing";
            label5.Text = "Not playing";
            label6.Text = "Not playing";

            button1.Text = "Play";
            button2.Text = "Stop";

            button3.Text = "Play";
            button4.Text = "Stop";

            button5.Text = "Play";
            button6.Text = "Stop";


            BluRay = new Bluray();
            
            button1.Click += new EventHandler(Playing);
            button3.Click += new EventHandler(Playing);
            button5.Click += new EventHandler(PlayingBluRay);
            button6.Click += new EventHandler(StopBluRay);
            
        }

        private void StopBluRay(object sender, EventArgs e)
        {
            label6.Text = Bluray.Play();
        }

        private void PlayingBluRay(object sender, EventArgs e)
        {
            label6.Text = Bluray.Stop();
        }

    }
}
