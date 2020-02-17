using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Le_Singleton
{
    public sealed class DatabaseSingleton
    {
        private static readonly Lazy<DatabaseSingleton> lazy = new Lazy<DatabaseSingleton>(() => new DatabaseSingleton());

        public static DatabaseSingleton Instance { get { return lazy.Value; } }

        private DatabaseSingleton()
        {
            Console.WriteLine("We create a new singleton");
        }
    }
}
