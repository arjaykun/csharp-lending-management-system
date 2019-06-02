using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LMSLibrary
{
    public static class Database
    {
        public static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["lms"].ConnectionString;
        }
    }
}
