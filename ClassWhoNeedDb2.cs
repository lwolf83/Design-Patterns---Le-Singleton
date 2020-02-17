using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Le_Singleton
{
    class ClassWhoNeedDb2
    {
        private DatabaseSingleton _database = DatabaseSingleton.Instance;

    }
}
