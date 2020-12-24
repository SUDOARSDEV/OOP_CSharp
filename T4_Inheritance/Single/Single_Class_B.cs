using System;
namespace InheritanceTypes
{
    public class Single_Class_B: Single_Class_A
    {
        public Single_Class_B()
        {
            Console.WriteLine("B (Derived) Class Constructor");
        }

        public void printB()
        {
            printA();
            Console.WriteLine("B is the derived Class of A");
        }
    }
}
