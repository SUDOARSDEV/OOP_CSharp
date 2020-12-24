using System;
namespace Constructor_Destructor
{
    public class Technology
    {
        public Technology() // Default Constructor
        {
            Console.WriteLine("C#");
        }

        public Technology(string name) // Customize Constructor 
        {
            Console.WriteLine("{0}",name);
        }

        ~Technology() { } // Destructor
    }
}
