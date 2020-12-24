using System;
namespace InheritanceTypes
{
    public class Hierarchical_Class_B:Hierarchical_Class_A
    {
        public Hierarchical_Class_B()
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
