using System;
namespace Abstraction
{
    public class News:YouTube
    {
        private string country;

        public News(string x = "null")
        {
            country = x;
        }

        // overriding of the abstract method of search 
        // class using the override keyword 
        public override string search()
        {
            Console.Write("{0} Mostly Searching ", country);
            return ("News Video");
        }

    }
}
