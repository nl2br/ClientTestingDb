using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestingDb
{
    public class SingleConnection
    {
        private static SingleConnection Instance = null;
        public SqlConnection ConnectionSQLServer { get; set; }

        public SqlConnection GetConnection()
        {
            return ConnectionSQLServer;
        }

        // constructeur innaccessible pour obliger a utiliser createInstance
        private SingleConnection()
        {
            ConnectionSQLServer = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marilou\Documents\mdsb3.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public static SingleConnection CreateInstance()
        {
            if(Instance == null)
            {
                Instance = new SingleConnection();
            }
            return Instance;
        }
    }
}
