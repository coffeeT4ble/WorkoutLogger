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
        }
        StartWorkoutDB startWorkoutDB = new StartWorkoutDB();

        private void StartWorkout_Click(object sender, EventArgs e)
        {
            WorkoutMenu wm = new WorkoutMenu();
            wm.Show();
            this.Close();
        }
    }
}
