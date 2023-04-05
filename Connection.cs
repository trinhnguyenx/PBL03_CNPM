using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PBL3_1._0_
{
     class Connection
    {
        private static string stringConnection = @"Data Source=LAPTOP-873V4A2C\SQLEXPRESS;Initial Catalog=LogIn;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}
