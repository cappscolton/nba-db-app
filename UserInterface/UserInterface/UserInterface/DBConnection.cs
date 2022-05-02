using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UserInterface
{
    public static class DBConnection
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog = NBA;Trusted_Connection=yes;");
    }
}
