using System;
namespace Method_overload
{
    public class Operator_overload
    {
        private int x;
        private int y;
        public Operator_overload()
        {
        }
        public Operator_overload(int i, int j)
        {
            x = i;
            y = j;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        public static Operator_overload operator -(Operator_overload c)
        {
            Operator_overload temp = new Operator_overload();
            temp.x = -c.x;
            temp.y = -c.y;
            return temp;
        }
    }
}
