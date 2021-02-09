using System;

namespace Encapsulation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Google_Search gs = new Google_Search();
            Console.Write("Google Search : ");
            gs.keyword = Convert.ToString(Console.ReadLine());
            gs.search();
        }
    }
}
