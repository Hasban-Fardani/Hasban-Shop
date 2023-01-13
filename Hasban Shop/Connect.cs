using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hasban_Shop
{
    internal class Connect
    {
        internal static MySqlConnection CreateConnection()
        {
            string Server = "gateway01.ap-southeast-1.prod.aws.tidbcloud.com";
            string Port = "4000";
            string database = "shop";
            string Uid = "2fQWCPVa5HCV1Bp.root";
            string pwd = "1dlRqAyP8FEdFFpE";
            try
            {
                MySqlConnection conn = new MySqlConnection(
                    $"Server={Server};Port={Port};Database={database};Uid={Uid};Pwd={pwd}");
                return conn;
            } catch
            {
                return null;
            }
        }
    }
}
