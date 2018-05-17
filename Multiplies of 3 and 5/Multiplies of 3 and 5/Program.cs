using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplies_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.Solution(10));
            Console.WriteLine(Kata.Solution2(10));
            Console.WriteLine(Kata.Solution3(10));
            Console.ReadLine();
        }
    }
    public static class Kata
    {

        //loop solution
        public static int Solution(int value)
        {
            var sum = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }else if (i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        } 

        public static int Solution2(int value)
        {
            return Enumerable.Range(0, value).Where(s => s % 3 == 0 || s % 5 == 0).Sum();
        }

        public static int Solution3(int value)
        {
            var sum = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) 
                {
                    sum += i;
                }
                
            }
            return sum;
        }
    }
}
