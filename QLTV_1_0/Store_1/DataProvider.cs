using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_1_0.Store_1
{
    internal class DataProvider
    {
        private string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QL_ThuVien_1_5;Integrated Security = True;";

        public DataTable ExecuteQuery  (string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
         
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
    }
}
