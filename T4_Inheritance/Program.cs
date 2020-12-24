using System;

namespace InheritanceTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Single_Class_B B = new Single_Class_B();
            //B.printB();

            //Multilevel_Class_C C = new Multilevel_Class_C();
            //C.printC();

            //Hierarchical_Class_B H_B = new Hierarchical_Class_B();
            //H_B.printB();

            //Hierarchical_Class_C H_C = new Hierarchical_Class_C();
            //H_C.printC();

            //Hierarchical_Class_D H_D = new Hierarchical_Class_D();
            //H_D.printD();

            Multiple_Class_A M_A = new Multiple_Class_A();
            M_A.printB();
            M_A.printC();
            M_A.printD();
        }
    }
}
