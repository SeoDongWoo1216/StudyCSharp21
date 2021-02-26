using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_26_02_DBConnTestApp
{
    class DBhelper
    {
        public IDbConnection GetDbConnection()
        {
            IDbConnection dbconn = null;
            string connString = ConfigurationManager.AppSettings["Connection"];
            var DBType = ConfigurationManager.AppSettings["DbType"];
            switch (DBType)
            {
                case "SQLServer":    // DB 접속은 모양이 다 똑같다.
                    dbconn = new SqlConnection(connString);
                    break;
                case "Oracle":
                    dbconn = new OracleConnection(connString);
                    break;
                case "OleDB":
                    dbconn = new OleDBConnection(connString);
                    break;
                default:
                    break;
            }
            return dbconn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
