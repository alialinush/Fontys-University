using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace FoodAndDrinkShop
{
    class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            

            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;Database=dbi416830;Uid=dbi416839;Pwd=Boi3Y/wgFM;");

            string sql = "SELECT Name_ FROM item;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
        }

        
        
    }
}
