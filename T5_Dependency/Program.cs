using System;

namespace Dependency
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Google Search Engine");
            Console.Write("Type Here : ");
            string text = Convert.ToString(Console.ReadLine()); // you know it input/ouput
            GoogleSearch google =new GoogleSearch(new USAServer());
            google.USA_Searching(text);

        }
    }
}
