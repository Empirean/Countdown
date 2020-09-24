using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class Form1 : Form
    {
        DateTime d;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d = new DateTime(2024, 01, 01);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now < d)
            {
                try
                {
                    TimeSpan  timeSpan = d - DateTime.Now;
                    lbl_timeLeft.Text =  timeSpan.Days.ToString() + ":" +
                                         timeSpan.Hours.ToString("00") + ":" +
                                         timeSpan.Minutes.ToString("00") + ":" +
                                         timeSpan.Seconds.ToString("00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
    
}
