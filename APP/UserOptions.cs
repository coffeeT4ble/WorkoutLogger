using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class UserOptions : Form
    {
        public UserOptions()
        {
            InitializeComponent();
            welcome.Text = "Welcome " + LoginDB.UserName + "!";
        }
        StartWorkoutDB startWorkoutDB = new StartWorkoutDB();

        private void StartWorkout_Click(object sender, EventArgs e)
        {
            WorkoutMenu wm = new WorkoutMenu();
            startWorkoutDB.startWorkout();
            wm.Show();
            this.Close();
        }

        private void get_log_button_Click(object sender, EventArgs e)
        {
            GetLogDB g = new GetLogDB();
            g.LogMaker();
            MessageBox.Show(g.completeLog(), "Workout Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calendar_button_Click(object sender, EventArgs e)
        {
            Calendar c = new Calendar();
            c.Show();
        }
    }
}
