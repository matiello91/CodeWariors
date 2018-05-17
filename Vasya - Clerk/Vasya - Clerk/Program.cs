using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasya___Clerk
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Line
    {
        public string Tickets(int[] peopleInLine)
        {
            int bill25 = 0;
            int bill50 = 0;
            int bill100 = 0;
            string result = "NO";
            for (int i=0; i<peopleInLine.Length; i++)//if 25 then add to wallet
            {
                if (peopleInLine[i] == 25)
                {
                    bill25++;
                    if (i == peopleInLine.Length - 1) return result = "YES";//if this is last client return YES
                }
                //else if (peopleInLine[i] == 50 && ((peopleInLine[i] - 25) / 25) <= bill25)//possible simplify? \/
                else if (peopleInLine[i] == 50 && bill25>=1) //client pay with 50, check if you have at least one 25bill in your wallet
                {
                    bill50++;
                    bill25--;
                    if (i == peopleInLine.Length - 1) return result = "YES";//if this is last client return YES
                }
                else if (peopleInLine[i] == 100 && (bill25 >= 3 || bill50 >= 1 && bill25 >= 1))
                {
                    if (bill50 >= 1 && bill25 >= 0)
                    {
                        bill50--;
                        bill25--;
                        bill100++;
                    }
                    else if (bill25 >= 3)
                    {
                        bill25 -= 3 * bill25;
                        bill100++;
                    }
                    bill50++;
                    bill25--;
                    if (i == peopleInLine.Length - 1) return result = "YES";//if this is last client return YES
                }
            }
            return result;
            //Your code is here...
        }
    }
}
