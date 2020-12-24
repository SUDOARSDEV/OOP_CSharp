using System;

namespace Access_Modifier
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            parent p = new parent();
            p.temp1 = 2;
            Console.WriteLine("{0} puclic modifier", p.temp1);
            p.print();
            child c = new child();
           
        }
    }

    class parent
    {
        public int temp1;
        private int temp2;
        protected int temp3;
        internal int temp4;

        public parent()
        {
            temp4 = 1;
            Console.WriteLine("{0} internal modifier",temp4);
        }

        public void print()
        {
            temp2 = 3;
            Console.WriteLine("{0} private modifier", temp2);
        }
    }

    class child:parent
    {
        public child()
        {
            temp3 = 4;
            Console.WriteLine("{0} protected modifier", temp3);
        }
    }
}
