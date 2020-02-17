using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Le_Singleton
{
    public sealed class DatabaseSingleton
    {
        private static DatabaseSingleton Database;


        public static DatabaseSingleton Instance { 
            get { 
                if(Database == null)
                { 
                    Database = new DatabaseSingleton(); 
                }
                return Database; 
            
            } 
        }

        private DatabaseSingleton()
        {
            Console.WriteLine("We create a new singleton");
        }
    }
}
