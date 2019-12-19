using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayToWin
{
    public class SqliteAcc
    {
        public static List<Userinos> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Userinos>("select * from Users", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<BuyOption> LoadPrice()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BuyOption>("select * from Pricess", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void Update(Userinos userinos)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Users set Points = @Points", userinos);

            }
        }
        public static void SaveUser(Userinos userinos)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Users (Username, Password, Email, Numbers, Date, Other, Points) values (@Username, @Password, @Email, @Numbers, @Date, @Other, @Points)", userinos);
            }
        }

        private static string LoadConnectionString(string id = "SecretData")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
