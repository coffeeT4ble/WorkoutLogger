using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class Calendar : Form
    {
        public static int _year, _month;
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            _month--;
            if (_month < 1)
            {
                _month = 12;
                _year--;
            }
            showDays(_month, _year);
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            _month++;
            if (_month > 12)
            {
                _month = 1;
                _year++;
            }
            showDays(_month, _year);
        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            month_label.Text = monthName.ToUpper() + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < week; i++)
            {
                ucDays uc = new ucDays("");
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= day; i++)
            {
                ucDays uc = new ucDays(i + "");
                flowLayoutPanel1.Controls.Add(uc);
            }
        }
    }
}
