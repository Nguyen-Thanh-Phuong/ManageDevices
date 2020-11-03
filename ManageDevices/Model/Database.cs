using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManageDevices.Model
{
    public class Database
    {
        private static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ToString());
        SqlCommand comm;
        public static Database instance = new Database();
        private Database() { }

        public SqlCommand connection(string query)
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            comm = new SqlCommand(query, conn);
            return comm;
        }
        public SqlCommand getCommStored(string storedName)
        {
            connection(storedName);
            comm.CommandType = CommandType.StoredProcedure;
            return comm;
        }
        public string Reader()
        {
            string result="";
            
            using (var reader = comm.ExecuteReader())
                while (reader.Read())
                    result += reader.GetString(0);

            return result;
        }
    }
}