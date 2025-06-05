using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    /// <summary>
    /// Handles operations related to starting a workout and loading exercises from the database.
    /// </summary>
    internal class StartWorkoutDB
    {
        /// <summary>
        /// Stores a dictionary of exercise names and their descriptions.
        /// Key: Exercise name (EName), Value: Exercise description (EDescription).
        /// </summary>
        public static Dictionary<string, string> exercises = new Dictionary<string, string>();
        public StartWorkoutDB() { }
        /// <summary>
        /// Loads all exercises from the database into the static dictionary if not already added.
        /// </summary>
        public void AddExercise()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT EName, EDescription FROM Exercises";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string exerciseName = reader.GetString(0);
                        string description = reader.GetString(1);
                        if (!exercises.ContainsKey(exerciseName))
                        {
                            exercises.Add(exerciseName, description);
                        }
                    }
                    reader.Close();
                }
            }
        }
        /// <summary>
        /// Returns a formatted string of all loaded exercises and their descriptions.
        /// </summary>
        /// <returns>A multi-line string containing all exercises and their details.</returns>
        public string getE()
        {
            StringBuilder all = new StringBuilder();
            foreach (var kvp in exercises)
            {
                all.AppendLine($"Exercise: {kvp.Key} - Description: {kvp.Value}\n");
            }
            return all.ToString();
        }
        /// <summary>
        /// Starts a workout session by inserting the current time and user ID into the database.
        /// </summary>
        public void startWorkout()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO WorkoutSessions(StartTime, UserID) VALUES(GETDATE(), "+LoginDB.UserId+");";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
