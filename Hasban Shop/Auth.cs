using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasban_Shop
{
    internal class Auth
    {
        protected MySqlConnection conn;
        public Auth()
        {
            conn = Connect.CreateConnection();
        }
        internal static bool Login(string username, string password)
        {

            return false;
        }
    }
}
