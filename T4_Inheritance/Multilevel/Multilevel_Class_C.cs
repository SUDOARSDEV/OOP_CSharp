using System;
namespace InheritanceTypes
{
    public class Multilevel_Class_C:Multilevel_Class_B
    {
        public Multilevel_Class_C()
        {
            Console.WriteLine("C (Derived) Class Constructor");
        }

        public void printC()
        {
            printA();
            printB();
            Console.WriteLine("C is the derived Class of B");
        }
    }
}
