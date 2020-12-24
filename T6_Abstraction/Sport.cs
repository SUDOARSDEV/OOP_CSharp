using System;
namespace Abstraction
{
    public class Sport : YouTube
    {
        private string country;

        public Sport(string x = "null")
        {
            country = x;
        }

        // overriding of the abstract method of search 
        // class using the override keyword 
        public override string search()
        {
            Console.Write("{0} Mostly Searching ", country);
            return ("Sport Video");
        }
    }
}
