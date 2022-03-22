using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilDatabaseApp
{
    public  class DBConnectionSingleton
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private DBConnectionSingleton()
        {
        }

        private static SqlConnection _instance = null;

        public static SqlConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SqlConnection(connectionString);
                    _instance.Open();
                }

                return _instance;
            }
        }


    }
}
