using System.Data;

namespace _21_02_26_02_DBConnTestApp
{
    internal class OleDBConnection : IDbConnection
    {
        private string connString;

        public OleDBConnection(string connString)
        {
            this.connString = connString;
        }
    }
}