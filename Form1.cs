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
                    TimeSpan timeSpan = d - DateTime.Now;
                    int monthsLeft, daysLeft;
                    (monthsLeft, daysLeft) = GetRemainingMonths(DateTime.Now, d);

                    lbl_timeLeft.Text =  (monthsLeft / 12).ToString() + " year," +
                                         (monthsLeft % 12).ToString() + " month, " +
                                         (timeSpan.Days - daysLeft).ToString() + " days, " +
                                         timeSpan.Hours.ToString("00") + " hours, " +
                                         timeSpan.Minutes.ToString("00") + " minutes, " +
                                         timeSpan.Seconds.ToString("00") + " seconds";
                                      
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }

        private (int, int) GetRemainingMonths(DateTime s, DateTime e)
        {
            int monthsLeft = 0;
            int daysLeft = 0;

            for (int i = s.Year; i <= e.Year; i++)
            {
                int initializer = 1;
                int condition = 12;

                if (i == s.Year)
                {
                    initializer = s.Month + 1;
                }

                if (i == e.Year)
                {
                    condition = e.Month -1;
                }

                for (int j = initializer; j <= condition; j++)
                {
                    
                    if ((i != s.Year && j != s.Month) || (i != e.Year && j != e.Month))
                    {
                        daysLeft += DateTime.DaysInMonth(i, j);

                    }
                    else
                    {
                        int init = 1;
                        int cond = DateTime.DaysInMonth(i, j);

                        if (init == s.Year && j == s.Month)
                        {
                            init = s.Day;
                        }

                        if (init == e.Year && j == e.Month)
                        {
                            cond = e.Day;
                        }

                        for (int k = init; k < cond; k++)
                        {
                            daysLeft++;
                        }
                    }
                   
                    monthsLeft++;
                }
            }

            return (monthsLeft, daysLeft);
        }

    }
    
}
