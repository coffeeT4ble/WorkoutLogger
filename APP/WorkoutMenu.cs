﻿using System;
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
    public partial class WorkoutMenu : Form
    {
        int index = 0;
        StartWorkoutDB startWorkoutDB = new StartWorkoutDB();
        SearchExerciseDB searchExerciseDB = new SearchExerciseDB();
        public WorkoutMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchExerciseDB.Search(search0, search1, search2, search3, search4, textBox1);
        }

        private void listOfExercises_Click(object sender, EventArgs e)
        {
            startWorkoutDB.AddExercise();
            MessageBox.Show(startWorkoutDB.getE());
        }

        private void search0_Click(object sender, EventArgs e)
        {
            if (search0.Text != "search0")
            {
                ExerciseSetting es = new ExerciseSetting();
                searchExerciseDB.getID(search0.Text);
                SearchExerciseDB.chosenExerciseName = search0.Text;
                es.Show();
                this.Close();
            }
        }

        private void search1_Click(object sender, EventArgs e)
        {
            if (search1.Text != "search1")
            {
                ExerciseSetting es = new ExerciseSetting();
                searchExerciseDB.getID(search1.Text);
                SearchExerciseDB.chosenExerciseName = search1.Text;
                es.Show();
                this.Close();
            }
        }

        private void search2_Click(object sender, EventArgs e)
        {
            if (search2.Text != "search2")
            {
                ExerciseSetting es = new ExerciseSetting();
                searchExerciseDB.getID(search2.Text);
                SearchExerciseDB.chosenExerciseName = search2.Text;
                es.Show();
                this.Close();
            }
        }

        private void search3_Click(object sender, EventArgs e)
        {
            if (search3.Text != "search3")
            {
                ExerciseSetting es = new ExerciseSetting();
                searchExerciseDB.getID(search3.Text);
                SearchExerciseDB.chosenExerciseName = search3.Text;
                es.Show();
                this.Close();
            }
        }

        private void search4_Click(object sender, EventArgs e)
        {
            if (search4.Text != "search4")
            {
                ExerciseSetting es = new ExerciseSetting();
                searchExerciseDB.getID(search4.Text);
                SearchExerciseDB.chosenExerciseName = search4.Text;
                es.Show();
                this.Close();
            }
        }

        private void end_workout_button_Click(object sender, EventArgs e)
        {
            UserOptions userOptions = new UserOptions();
            userOptions.Show();
            this.Close();
        }
    }
}
