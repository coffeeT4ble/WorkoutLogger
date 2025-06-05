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
    public partial class ExerciseSetting : Form
    {
        public ExerciseSetting()
        {
            InitializeComponent();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(weight_counter.Value) > 0 && Convert.ToInt32(sets_counter.Value) > 0 && Convert.ToInt32(reps_counter.Value) > 0) {
                ConfirmSetsReps confirmSetsReps = new ConfirmSetsReps();
                confirmSetsReps.confirm(Convert.ToInt32(weight_counter.Value), Convert.ToInt32(sets_counter.Value), Convert.ToInt32(reps_counter.Value));
                WorkoutMenu wm = new WorkoutMenu();
                wm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid values for weight, sets, and reps.");
            }
        }
    }
}
