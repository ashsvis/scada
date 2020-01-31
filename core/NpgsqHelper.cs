using Npgsql;
using System.Data;
using System.Linq;

namespace awp
{
    public static class NpgsqHelper
    {
        private static NpgsqlConnection _dbcon;
        private static IDbCommand _dbcmd;
        private static IDataReader _reader;
        private static string _dbName;

        public static bool CreateNotExistDatabase(string dbname)
        {
            try
            {
                Open("postgres");
                try
                {
                    var ds = GetDatabases();
                    if (ds.Tables[0].Rows.Cast<DataRow>() 
                                    .All(row => row["datname"].ToString() != dbname))
                    {
                        var command = new NpgsqlCommand(
                            string.Format("create database {0} template template1", dbname), _dbcon);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                finally
                {
                    Close();
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        public static bool DeleteExistDatabase(string dbname)
        {
            try
            {
                Open("postgres");
                try
                {
                    var ds = GetDatabases();
                    if (ds.Tables[0].Rows.Cast<DataRow>()
                        .Any(row => row["datname"].ToString() == dbname))
                    {
                        var command = new NpgsqlCommand(
                            string.Format("drop database {0}", dbname), _dbcon);
                        _reader = command.ExecuteReader();
                        _reader.Close();
                        return true;
                    }
                }
                finally
                {
                    Close();
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        public static void CreatePointsTable(string dbname)
        {
            Open(dbname);
            try
            {
                if (TableExist("points")) return;
                const string sql =
                    "create table points (name varchar(25) not null, prop varchar(25) not null, value varchar(100) not null, snaptime timestamp not null, unique(name, prop));";
                var command = new NpgsqlCommand(sql, _dbcon);
                command.ExecuteNonQuery();
            }
            finally
            {
                Close();
            }
        }

        public static void Open(string dbname)
        {
            var connectionString =
                string.Format("Server=localhost;Database={0};User ID=postgres;Password=3141592653;",
                dbname);
            _dbName = dbname;
            _dbcon = new NpgsqlConnection(connectionString);
            _dbcon.Open();
            _dbcmd = _dbcon.CreateCommand();
        }

        public static void Close()
        {
            _dbcon.Close();
        }

        private static bool TableExist(string tbname)
        {
            try
            {
                var ds = GetTables();
                if (ds.Tables[0].Rows.Cast<DataRow>()
                                .Any(row => row["tablename"].ToString().ToLower() == tbname.ToLower()))
                    return true;
            }
            catch
            {
                return false;
            }
            return false;
        }

        public static bool DatabaseExist(string dbname)
        {
            try
            {
                Open("postgres");
                try
                {
                    var ds = GetDatabases();
                    if (ds.Tables[0].Rows.Cast<DataRow>()
                                    .Any(row => row["datname"].ToString().ToLower() == dbname.ToLower()))
                        return true;
                }
                finally
                {
                    Close();
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        private static DataSet GetTables()
        {
            var myDataAdapter = new NpgsqlDataAdapter("select * from pg_tables;", _dbcon);
            var ds = new DataSet();
            myDataAdapter.Fill(ds, "Tables");
            return ds;
        }

        private static DataSet GetDatabases()
        {
            var myDataAdapter = new NpgsqlDataAdapter("select * from pg_database;", _dbcon);
            var ds = new DataSet();
            myDataAdapter.Fill(ds, "Databases");
            return ds;
        }

    }
}
