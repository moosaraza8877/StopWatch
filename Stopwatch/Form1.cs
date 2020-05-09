using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        public int miliseconds;
        public int seconds;
        public int minutes;
        public int hours;
       
        public Form1()
        {
            InitializeComponent();
            hours = minutes = seconds = miliseconds = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            miliseconds++;
            if (miliseconds > 9)
            {
                seconds++;
                miliseconds = 0;
            }
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes > 59)
            {
                hours++;
                minutes = 0;
            }

            lblmiliseconds.Text = Change(miliseconds);
            lblseconds.Text = Change(seconds);
            lblminutes.Text = Change(minutes);
            lblhours.Text = Change(hours);
        }

        private string Change(int value)
        {
            if (value < 10)
            {
                return "0" + value.ToString();
            }

            else
            {
                return value.ToString();
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            hours = minutes = seconds = miliseconds = 0;

            lblmiliseconds.Text = Change(miliseconds);
            lblseconds.Text = Change(seconds);
            lblminutes.Text = Change(minutes);
            lblhours.Text = Change(hours);
        }  
    }
}
