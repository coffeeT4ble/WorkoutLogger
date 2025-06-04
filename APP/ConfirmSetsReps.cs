using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    internal class ConfirmSetsReps
    {
        public ConfirmSetsReps(int sets, int reps) 
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

            }
        }
    }
}
