using System;

namespace Poly
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            type_1 t1 = new type_1();
            t1.combine(2, 4);
            t1.combine("c", "#");

            type2a ta = new type2a();
            ta.info();
            type2b tb = new type2b();
            tb.info();
        }
    }
}
