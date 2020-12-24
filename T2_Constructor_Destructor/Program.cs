using System;

namespace Constructor_Destructor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Technology t1 = new Technology();
            Technology t2 = new Technology("Asp.net");
            Technology t3 = new Technology("Angular 10"); 
        }
    }
}
