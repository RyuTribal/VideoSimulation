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
        IOperate VHS;
        IOperate DVD;
        IOperate BluRay;
        public int switcher;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "VIDEO";
            label2.Text = "DVD";
            label3.Text = "BLURAY";
            label4.Text = "Not playing";
            label5.Text = "Not playing";
            label6.Text = "Not playing";

            button1.Text = "Play";
            button2.Text = "Stop";

            button3.Text = "Play";
            button4.Text = "Stop";

            button5.Text = "Play";
            button6.Text = "Stop";


            VHS = new VideoPlayer();
            BluRay = new Bluray();

            button1.Click += new EventHandler(PlayingVHS);
            button2.Click += new EventHandler(StoppedVHS);
        }

        private void StoppedVHS(object sender, EventArgs e)
        {
            label4.Text = VHS.Stop();
        }

        private void PlayingVHS(object sender, EventArgs e)
        {
            label4.Text = VHS.Play();          
            
        }

        private void StopBluRay(object sender, EventArgs e)
        {
            label6.Text = BluRay.Play();

        }

        private void PlayingBluRay(object sender, EventArgs e)
        {
            label6.Text = BluRay.Stop();
        }

    }
}
