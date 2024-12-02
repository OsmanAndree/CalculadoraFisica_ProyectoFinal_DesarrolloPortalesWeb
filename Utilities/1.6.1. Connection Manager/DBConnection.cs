using System.Data;
using System.Data.OleDb;

namespace Utilitiess.ConnectionManager
{
    public class DBConnection
    {
        private OleDbConnection _connection;
        private string _stringConnection;

        public DBConnection(string DataSource, string DataBase, string Provider)
        {
            _stringConnection = $"Provider={Provider}; Data Source={DataSource}; Initial Catalog={DataBase}; Integrate Security=SSPI; Trust Server Certificate=False";
        }

        public void CreateConnection()
        {
            _connection = new OleDbConnection(_stringConnection);
        }

        public OleDbConnection Open()
        {
            if (_connection == null) return null;
            if (_connection.State == ConnectionState.Open) return _connection;
            else
            {
                _connection.Open();
                return _connection;
            }
        }

        public void Close()
        {
            _connection.Close();
        }
    }
}
