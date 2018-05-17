using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_The_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = new CountDig();
            Console.WriteLine(count.NbDig(20, 1));
            Console.WriteLine(count.NbDig2(20, 1));
            Console.ReadLine();
        }
    }
    public class CountDig
    {


        public int NbDig(int n, int d)
        {
            //can use IEnumerable.Range(0, n)?
            var digit = Convert.ToString(d);
            var charDigit = Convert.ToChar(digit);
            var intArray = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                intArray[i] = (int)Math.Pow(i,2);
            }

            var resultString = string.Join("", intArray);
            var count = 0 ;
            //for (int i = 0; i < resultString.Length; i++)
            //{
            //    if(resultString[i]==charDigit) count++;
            //} //replaced by below
            count = resultString.Count(s => s == charDigit);
            
            return count;
        }
        public int NbDig2(int n, int d)
        {
          

            var count = Enumerable.Range(0, n + 1).Select(i => (i * i).ToString().Count(c => c - 48 == d)).Sum();

            return count;
        }
    }
}
