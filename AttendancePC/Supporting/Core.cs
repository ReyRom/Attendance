using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendancePC.Models.Entities;

namespace AttendancePC.Supporting
{
    public class Core
    {
        static AttendanceEntities context;

        public static AttendanceEntities Context { get => context ?? (context = new AttendanceEntities()); }

        public static string Server { get => server; set => server = value; }
        public static string Database { get => database; set => database = value; }
        public static string Login { get => login; set => login = value; }
        public static string Password { get => password; set => password = value; }

        static string server = Context.Database.Connection.DataSource;
        static string database = Context.Database.Connection.Database;
        static string login = "sa";
        static string password = "1";

        public static void RenewConnectionString()
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = server;
            sqlConnection.InitialCatalog = database;
            sqlConnection.UserID = login;
            sqlConnection.Password = password;
            Context.Database.Connection.ConnectionString = sqlConnection.ConnectionString;
        }
    }
}
