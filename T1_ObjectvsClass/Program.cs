using System;

namespace ObjectvsClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car(); // object 1
            Car c2 = new Car(); // object 2
            c1.start();
            c2.start();
        }
    }
}
