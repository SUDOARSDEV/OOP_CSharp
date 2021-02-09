using System;
namespace Method_Override
{
    public class Calculation:Cashier_Machine
    {
        public Calculation()
        {
        }

        public override void cashier(int num1, int num2)
        {
            int result = num2 - num1;
            Console.WriteLine("Customer return cash {0}", result);
            Console.WriteLine("________________________________");
        }
    }
}
