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
