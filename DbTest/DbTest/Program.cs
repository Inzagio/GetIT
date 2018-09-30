using System.Data.SqlClient;

namespace DbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbPath =
                @"Data Source=(localdb)\MSSQLLocalDB;"+
                "Initial Catalog=TrymTest;"+
                "Integrated Security=True;"+
                "Connect Timeout=30;"+
                "Encrypt=False;"+
                "TrustServerCertificate=False;"+
                "ApplicationIntent=ReadWrite;"+
                "MultiSubnetFailover=False";
            var connection = new SqlConnection(dbPath);
        }
    }
}
