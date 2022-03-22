using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    class MainClass
    {
        public static SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
    }
}
