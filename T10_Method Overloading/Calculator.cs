using System;
namespace Method_overload
{
    public class Calculator
    {
        public Calculator()
        {
        }


        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public float Add(float num1, float num2)
        {
            return (num1 + num2);
        }
    }
}
