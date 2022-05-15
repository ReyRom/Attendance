using AttendancePC.Models.Entities;
using System;
using System.Data.SqlClient;
using System.IO;

namespace AttendancePC.Supporting
{
    public static class Core
    {
        static AttendanceEntities context;
        public static AttendanceEntities Context { get => context ?? (context = new AttendanceEntities()); }

        #region Connection
        public static string Server 
        { 
            get => Properties.Settings.Default.server; 
            set
            { 
                Properties.Settings.Default.server = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string Database 
        { 
            get => Properties.Settings.Default.database;
            set
            {
                Properties.Settings.Default.database = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string Login 
        {
            get => Properties.Settings.Default.login;
            set
            {
                Properties.Settings.Default.login = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string Password
        {
            get => Properties.Settings.Default.password;
            set
            {
                Properties.Settings.Default.password = value;
                Properties.Settings.Default.Save();
            }
        }

        public static void RenewConnectionString()
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = Server;
            sqlConnection.InitialCatalog = Database;
            sqlConnection.UserID = Login;
            sqlConnection.Password = Password;
            Context.Database.Connection.ConnectionString = sqlConnection.ConnectionString;
        }
        #endregion
    }
}
