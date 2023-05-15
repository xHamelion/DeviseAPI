using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DeviseAPI
{
    public  class SQLconsect
    {
        public SqlConnection Sql()
        {
            SqlConnection ms = new SqlConnection(@"Data Source=DESKTOP-J96IBMI;Initial Catalog=Devise;Integrated Security=True");

            return ms;
        }
    }
}