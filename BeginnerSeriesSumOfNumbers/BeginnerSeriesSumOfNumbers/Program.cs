using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerSeriesSumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            Console.WriteLine(sum.GetSum(1, 0));
            Console.WriteLine(sum.GetSum(1, 2));
            Console.WriteLine(sum.GetSum(0, 1));
            Console.WriteLine(sum.GetSum(1, 1));
            Console.WriteLine(sum.GetSum(-1, 0));
            Console.WriteLine(sum.GetSum(1, 0));
            Console.WriteLine(sum.GetSum(-1, 2));
            Console.ReadLine();

        }
    }
    public class Sum
    {
        public int GetSum(int a, int b)
        {
            if (a == b) return a;
            var sum = 0;
            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                sum += i;
            }
            return sum;
        }//zrobic za pomoca ciagu arytmetyczngo
    }
}
