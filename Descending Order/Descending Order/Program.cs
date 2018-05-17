using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cata.DescendingOrder(124356879));
            Console.ReadLine();
        }
    }
    
    public static class Cata
    {
        //make without list, orderby method available i Array function
        public static int DescendingOrder(int num)
        {
            var strNum = num.ToString();
            
            var charNum = strNum.ToCharArray();            
            var intList = new List<int>();
            
            foreach (var item in charNum)
            {
                intList.Add(int.Parse(item.ToString()));
            }
            
            intList = intList.OrderByDescending(x => x).ToList();
            var intArray = intList.ToArray();         
            return int.Parse(String.Join("", intArray.Select(x => x.ToString())));
        }
    }
}
