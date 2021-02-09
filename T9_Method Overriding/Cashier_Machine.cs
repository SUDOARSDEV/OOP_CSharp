using System;
namespace Method_Override
{
    public class Cashier_Machine
    {
        public Cashier_Machine()
        {
        }

        public virtual void cashier(int num1,int num2)
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("Total Amount : {0}", num1 );
            Console.WriteLine("Customer give {0} cash", num2);
        }
    }
}
