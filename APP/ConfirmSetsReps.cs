using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APP
{
    internal class ConfirmSetsReps
    {
        public ConfirmSetsReps() { }
        public void confirm(int weight, int sets, int reps) 
        {
            pullRecentWorkoutId();
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = $"INSERT INTO WorkoutLogs(WorkoutID, ExerciseID, WWeight, WSets, RepsPerSet) VALUES ({recentWorkoutId}, {SearchExerciseDB.chosenExerciseID}, {weight}, {sets}, {reps})";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        
                    }
                    reader.Close();
                }
            }
        }
        public static int recentWorkoutId;
        public static DateTime recentWorkoutStartTime;
        public void pullRecentWorkoutId()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT TOP 1 WorkoutID, StartTime FROM WorkoutSessions ORDER BY StartTime DESC;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        recentWorkoutId = reader.GetInt32(0);
                        recentWorkoutStartTime = reader.GetDateTime(1);
                    }
                    reader.Close();
                }
            }
        }
    }
}
