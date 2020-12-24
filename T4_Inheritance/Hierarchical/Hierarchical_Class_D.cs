using System;
namespace InheritanceTypes
{
    public class Hierarchical_Class_D:Hierarchical_Class_A
    {
        public Hierarchical_Class_D()
        {
            Console.WriteLine("D (Derived) Class Constructor");
        }
        public void printD()
        {
            printA();
            Console.WriteLine("D is the derived Class of A");
        }
    }
}
