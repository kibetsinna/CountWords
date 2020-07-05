using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class Program
    {

        public static Dictionary<string, int> Counters { get; set; }

        public static Dictionary<string, string> wordsToABC { get; set; }

        public static void countwords(string[] words)
        {
            foreach (var word in words)
            {
                string sortedWord = String.Concat(word.OrderBy(c => c));

                if (!Counters.ContainsKey(sortedWord))
                {
                    Counters.Add(sortedWord, 0);
                    wordsToABC.Add(word, sortedWord);
                }

                Counters[sortedWord] += 1;

            }
        }
        private static void printResults()
        {
            foreach (var word in wordsToABC)
            {
                int count = 0;
                Counters.TryGetValue(word.Value, out count);
                Console.WriteLine(string.Format("{0} : {1}", word.Key, count));
            }
        }
        static void Main(string[] args)
        {
            string[] arr = new string[] { "java", "jjava", "vaj", "aavj", "j", "vjaa", "dan", "and", "ddan" };
            Counters = new Dictionary<string, int>();
            wordsToABC = new Dictionary<string, string>();

            countwords(arr);
            printResults();

            Console.ReadLine();
        }

       

    }
}
