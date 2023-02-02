using System;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtbashCipher
{
    class Database
    {
        private string DataSource;
        public Database()
        {
            DataSource = "DataSource = database.db";
            if (File.Exists(@"database.db") == false)
            {
                InitializeDatabase();
            }
        }
        public bool InitializeDatabase()
        {
            SQLiteConnection connection = new SQLiteConnection(DataSource);
            try
            {
                connection.Open();
                SQLiteCommand cmd = connection.CreateCommand();
                string sql_command = "DROP TABLE IF EXISTS users;"
                + "CREATE TABLE users("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                + "login TEXT, "
                + "password TEXT)";

                cmd.CommandText = sql_command;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Dispose();
            }
            return true;
        }
        public bool CheckUser(string username, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(DataSource);

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT COUNT(*) "
                + "FROM users "
                + "where login = '{0}' AND "
                + "password = '{1}'",
                username, password);
                var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                return usersCount > 0;
            }
            return false;
        }
        public bool CreateUser(string username, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(DataSource);

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO users (login, password)"
                + "VALUES ('{0}', '{1}')",
                username, password);
                cmd.ExecuteNonQuery();
                return true;
            }
            return true;
        }
        public bool CheckCorrect(string username)
        {
            SQLiteConnection conn = new SQLiteConnection(DataSource);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("SELECT COUNT(*) "
            + "FROM users "
            + "where login = '{0}'", username);
            int usersCount = Convert.ToInt32(cmd.ExecuteScalar());
            return usersCount > 0;

        }
    }
}
