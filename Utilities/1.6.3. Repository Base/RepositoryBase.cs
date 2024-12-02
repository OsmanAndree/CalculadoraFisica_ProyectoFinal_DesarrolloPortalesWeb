using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Connection_Manager;
using Utilities.Data_Base;

namespace Utilities._1._6._3._Repository_Base
{
    public abstract class RepositoryBase
    {
        public OleDbConnection _connection;
        protected RepositoryBase()
        {
            DBConnection connection = new DBConnection("(local)", "Northwind", "MSOLEDBSQL.1");
            _connection = connection.Open();

        }

        public abstract Data ProcessRequest(Data data);
    }
}
