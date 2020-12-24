using System;
namespace InheritanceTypes
{
    public class Hierarchical_Class_C:Hierarchical_Class_A
    {
        public Hierarchical_Class_C()
        {
            Console.WriteLine("C (Derived) Class Constructor");
        }

        public void printC()
        {
            printA();
            Console.WriteLine("C is the derived Class of A");
        }
    }
}
