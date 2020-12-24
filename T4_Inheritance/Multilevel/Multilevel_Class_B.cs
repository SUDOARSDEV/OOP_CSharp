using System;
namespace InheritanceTypes
{
    public class Multilevel_Class_B:Multilevel_Class_A
    {
        public Multilevel_Class_B()
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
