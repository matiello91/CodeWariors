using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_Odd_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            var kata = new Kata();
            int[] testInput = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            Console.WriteLine(kata.find_it(testInput));
        }
    }
    public class Kata
    {
        public int find_it(int[] seq)
        {
            //for avoid checking twice same number
            var dictionary = new Dictionary<int, int>();
            int result=-1;
            foreach (var item in seq)
            {
                //for avoid checking twice same number
                if (dictionary.ContainsKey(item))
                {
                    continue;
                }
                dictionary.Add(item, 0);
                //how to increase velue in dictionary
                var count = seq.Where(i => i == item).Count();
                if (count % 2 == 1)
                {
                    return result = item;
                }

            }
            return result;
        }
    }
}
