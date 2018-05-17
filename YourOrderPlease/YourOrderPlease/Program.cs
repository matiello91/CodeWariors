using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourOrderPlease
{
    class Program
    {
        static void Main(string[] args)
        {
            //zrobic co by sie nie wysypywalo przy tym samym kluczu - done
            //zastepowanie wartosci klucza nowa wartoscia przy dwoch takich samych kluczach
            Console.WriteLine(Kata.Order("9yffghh Th1s gu3s ih2 o4hiuy o4hiuy "));
            Console.WriteLine(Kata.Order2("9yffghh Th1s gu3s ih2 o4hiuy o4hiuy "));
            Console.ReadLine();
        }
    }
    public static class Kata
    {
        public static string Order(string words)
        {
            var wordsSeparated = words.Split(' ');
            var list = new Dictionary<int, string>();
            var index = 0;
            for (int i = 0; i < wordsSeparated.Length; i++)
            {
                var splitWordsSeparated = wordsSeparated[i].ToCharArray();
        
                foreach(var item in splitWordsSeparated)
                {
                    var isNumber = int.TryParse(item.ToString(), out index);
                    //Console.WriteLine(item);
                    if (isNumber)
                    {
                        if (!list.Keys.Contains(index))
                        {
                            list.Add(index, wordsSeparated[i]);
                            continue;
                        }
                    }
                }
            }

            var items = from keys in list
                        orderby keys.Key ascending
                        select keys.Value;

            string finalString = String.Join(" ", items);

            return finalString;

            //throw new NotImplementedException();
        }

        public static string Order2(string words)
        {
            if (string.IsNullOrEmpty(words))
            {
                return words;
            }

            return string.Join(" ", words.Split(' ')
                .OrderBy(s => s.ToList()
                .Find(c => char.IsDigit(c)))); 
        }
    }
}
