using System;

namespace Method_overload
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("Result is {0}", cal.Add(12.3f, 12.1f));


            Operator_overload num1 = new Operator_overload(-10, 20);
            num1.ShowXY(); // displays 10 & 20  
            Operator_overload num2 = new Operator_overload();
            num2.ShowXY(); // displays 0 & 0  
            num2 = -num1;
            num2.ShowXY(); //
        }
    }
}
