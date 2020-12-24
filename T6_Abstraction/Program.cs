using System;

namespace Abstraction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // creating reference of view class 
            // which refer to Technolgy class instance 
            YouTube yt = new Technology("England");

            // calling the method 
            string result = yt.search();

            Console.WriteLine("{0}", result);

            YouTube yt1 = new Sport("USA");

            // calling the method 
            string result1 = yt1.search();

            Console.WriteLine("{0}", result1);


            YouTube yt2 = new News("Canada");

            // calling the method 
            string result2 = yt2.search();

            Console.WriteLine("{0}", result2);



        }
    }
}
