using System;

namespace Design_Patterns___Le_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWhoNeedDb1 instance1 = new ClassWhoNeedDb1();
            ClassWhoNeedDb1 instance2 = new ClassWhoNeedDb1();
        }
    }
}
