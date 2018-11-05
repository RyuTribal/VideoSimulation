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

            DVD = new VideoPlayer();

            button3.Click += new EventHandler(PlayDVD);
            button4.Click += new EventHandler(StopDVD);
        }

        private void PlayDVD(object sender,EventArgs e)
        {
            label5.Text = DVD.Play();

        }

        private void StopDVD(object sender,EventArgs e)
        {
            label5.Text = DVD.Stop();
        }

    }
}
