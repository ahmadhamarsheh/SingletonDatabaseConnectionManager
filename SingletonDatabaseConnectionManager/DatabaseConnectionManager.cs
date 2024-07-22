using System;
using System.Data.SqlClient;

namespace SingletonDatabaseConnectionManager
{
    public class DatabaseConnectionManager
    {
        private static DatabaseConnectionManager _instance;

        private static readonly object _lock = new object();

        private DatabaseConnectionManager()
        {
            Console.WriteLine("DatabaseConnectionManager initialized.");
        }

        public static DatabaseConnectionManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DatabaseConnectionManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Connect()
        {
            Console.WriteLine("Simulated database connection opened.");
        }

        public void Disconnect()
        {
            Console.WriteLine("Simulated database connection closed.");
        }
    }
}
