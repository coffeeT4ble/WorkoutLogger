using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class ucDays : UserControl
    {
        string _day, date, weekday;
        /// <summary>
        /// Initializes a new instance of the ucDays UserControl with a specified day.
        /// Sets label text and hides the checkbox.
        /// </summary>
        /// <param name="day">The day of the month represented by this control.</param>
        private void panel1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(Calendar._year, Calendar._month, Convert.ToInt32(_day));
            string selectedDateString = selectedDate.ToString("yyyy-MM-dd");
            CalendarLogsDB db = new CalendarLogsDB();
            db.LogMaker(selectedDateString);
            MessageBox.Show($"Logs for {_day} {Calendar._month}/{Calendar._year}\n{db.completeLog()}", "Logs Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CalendarLogsDB.logList.Clear();
        }
        /// <summary>
        /// Event handler for when the control is loaded.
        /// (Currently unused, but can be used for initialization.)
        /// </summary>
        public ucDays(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = _day;
            checkBox1.Hide();
            date = $"{_day}/{Calendar._month}/{Calendar._year}";
        }

        private void ucDays_Load(object sender, EventArgs e)
        {

        }
    }
}
