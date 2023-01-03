using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineApp.DAO
{
    internal class DataProvider
    {
        private string connectionStr = "Data Source=DESKTOP-76MJ0U2;Initial Catalog=DemoDB;Integrated Security=True";
        
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
                
            using (SqlConnection conn = new SqlConnection(Program.stConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                conn.Close();

            }
            return dataTable;
            
        }
    }
}
