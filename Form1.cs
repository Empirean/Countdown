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
        bool isDragged = false;

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
                    int monthsLeft, daysLeft;

                    TimeSpan timeSpan = d - DateTime.Now;


                    (monthsLeft, daysLeft) = GetRemainingMonths(DateTime.Now, d);

                    int years = monthsLeft / 12;
                    int months = monthsLeft % 12;
                    int days = timeSpan.Days - daysLeft;
                    
                    lbl_timeLeft.Text =  years.ToString() + (years > 1 ? " years, \n" : " year, \n") +
                                            months.ToString() + (months > 1 ? " months, \n" : " month, \n") + 
                                            days.ToString() + (days > 1 ? " days, \n" : " day, \n") +
                                            timeSpan.Hours.ToString() + (timeSpan.Hours > 1 ? " hours, \n" : " hour, \n") +
                                            timeSpan.Minutes.ToString() + (timeSpan.Minutes > 1 ? " minutes, \n" : " minute, \n") +
                                            timeSpan.Seconds.ToString() + (timeSpan.Seconds > 1 ? " seconds. \n" : " second. \n");
                                      
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {
                lbl_timeLeft.Text = "BISCO MAKING TIME!!!";
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

        private void lbl_timeLeft_MouseDown(object sender, MouseEventArgs e)
        {

            isDragged = true;

        }

        private void lbl_timeLeft_MouseMove(object sender, MouseEventArgs e)
        {
                
            if (isDragged)
            {
                MoveMouse();
            }

        }

        private void lbl_timeLeft_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
            
        }

        private void MoveMouse()
        {
            lbl_timeLeft.Top = MousePosition.Y;
            lbl_timeLeft.Left = MousePosition.X;
        }
    }
    
}
