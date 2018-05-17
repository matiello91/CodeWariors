using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round_To_The_Next_Multiply_by_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var kata = new Kata2();
            Console.WriteLine(kata.RoundToNext5(6));
            Console.ReadLine();
        }
    }
    public class Kata2
    {
        public int RoundToNext5(int n)
        {
            while (n % 5 != 0)
            {
                n++;
            }
            return n;
        }
    }
}
