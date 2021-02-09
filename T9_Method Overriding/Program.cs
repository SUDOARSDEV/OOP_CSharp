using System;

namespace Method_Override
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cashier_Machine cm;
            int amount;
            int cash;

            Console.Write("Type Total Amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("User Cash : ");
            cash = Convert.ToInt32(Console.ReadLine());

            cm = new Cashier_Machine();
            cm.cashier(amount, cash);
            cm = new Calculation();
            cm.cashier(amount, cash);

        }
    }
}
