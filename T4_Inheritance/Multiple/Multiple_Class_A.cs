using System;
namespace InheritanceTypes
{
    public class Multiple_Class_A:Multiple_Interface_B,Multiple_Interface_C,Multiple_Interface_D
    {
        public Multiple_Class_A()
        {
            Console.WriteLine("A (Base) Class Constructor");
        }

        public string printB()
        {
            Console.WriteLine ("B is the interface of A");
            return "Done";
        }

        public string printC()
        {
            Console.WriteLine("C is the interface of A");
            return "Done";
        }

        public string printD() 
        {
            Console.WriteLine("D is the interface of A");
            return "Done";
        }
    }
}
