using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAPP.DataAcess
{
    public class SqlDataAcess: IDBOperator
    {
        private static SqlDataAcess instance;
        private SqlDataAcess()
        {
            
        }
        public static SqlDataAcess Instance()
        {
           return instance ?? (instance =  new SqlDataAcess());
        }
        SqlConnection sqlConnection;
        SqlCommand Command;
        SqlDataAdapter adapter;
        private void Dispose()
        {
            if (sqlConnection != null)
            {
                sqlConnection.Dispose();
                sqlConnection = null;
            }
            if (Command != null)
            {
                Command.Dispose();
                Command = null;
            }
            if (adapter != null)
            {
                adapter.Dispose();
                adapter = null;
            }
        }
        public bool Open(string url)
        {
            string constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(url);
            }
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Close()
        {
            throw new NotImplementedException();
        }

        public bool Query(string command)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string command)
        {
            throw new NotImplementedException();
        }

        public bool Update(string command)
        {
            throw new NotImplementedException();
        }

        public bool Add(string command)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAll(string command)
        {
            throw new NotImplementedException();
        }
    }
}
