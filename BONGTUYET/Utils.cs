using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

namespace BONGTUYET
{
    public class Utils
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sad;
        SqlDataReader sdr;
        DataTable dt;

        public static string getConnection()
        {
            return ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        }
    }
}