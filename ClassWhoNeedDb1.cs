using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Le_Singleton
{
    class ClassWhoNeedDb1
    {
        private DatabaseSingleton _database = DatabaseSingleton.Instance;
    }
}
