using System.Data.SqlClient;

namespace SingletonDatabaseConnectionManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbManager1 = DatabaseConnectionManager.Instance;
            var dbManager2 = DatabaseConnectionManager.Instance;

            if (dbManager1 == dbManager2)
            {
                Console.WriteLine("Both instances are the same.");
            }
            else
            {
                Console.WriteLine("Instances are different.");
            }

            dbManager1.Connect();
            dbManager2.Disconnect();
        }
    }
}
