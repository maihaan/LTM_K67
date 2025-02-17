using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Socket_Server
{
    public class DBSupport
    {
        String connectionString = "Data Source=.\\MSSQL; initial catalog=LTM_K67; user id=admin; password=@n123456;";
        SqlConnection connection;

        public DBSupport()
        {
            connection = new SqlConnection(connectionString);
        }

        public DataTable Doc(String query)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader, LoadOption.OverwriteChanges);                
                connection.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }

        public int Ghi(String query)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                int dem = cmd.ExecuteNonQuery();
                connection.Close();
                return dem;
            }
            catch
            {
                return -2;
            }
        }

    }
}
