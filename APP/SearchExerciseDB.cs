using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    internal class SearchExerciseDB
    {
        public SearchExerciseDB() { }
        public static int chosenExerciseID;
        public static string chosenExerciseName;
        /// <summary>
        /// Searches for exercises that match the text in the given TextBox and displays up to 5 results in the provided labels.
        /// </summary>
        /// <param name="s0">Label for the first result.</param>
        /// <param name="s1">Label for the second result.</param>
        /// <param name="s2">Label for the third result.</param>
        /// <param name="s3">Label for the fourth result.</param>
        /// <param name="s4">Label for the fifth result.</param>
        /// <param name="t">TextBox containing the search input.</param>
        public void Search(Label s0, Label s1, Label s2, Label s3, Label s4, TextBox t)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT EName, EDescription FROM Exercises WHERE EName LIKE '%" + t.Text + "%';";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    int index = 0;
                    while (reader.Read() && index < 5)
                    {
                        string exerciseName = reader.GetString(0);
                        switch (index)
                        {
                            case 0: s0.Text = exerciseName; break;
                            case 1: s1.Text = exerciseName; break;
                            case 2: s2.Text = exerciseName; break;
                            case 3: s3.Text = exerciseName; break;
                            case 4: s4.Text = exerciseName; break;
                        }
                        index++;
                    }
                    reader.Close();
                }
            }
        }
        /// <summary>
        /// Retrieves the ID of a given exercise name from the database and stores it in <c>chosenExerciseID</c>.
        /// </summary>
        /// <param name="eName">The exact name of the exercise to look up.</param>
        public void getID(string eName)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ExerciseID FROM Exercises WHERE EName = '"+eName+"'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        chosenExerciseID = reader.GetInt32(0);
                    }
                    reader.Close();
                }
            }
        }
    }
}
