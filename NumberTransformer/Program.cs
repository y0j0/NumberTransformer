using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTransformer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(100);
            for (int i = 1; i <= 100; i++)
            {
                numbers.Add(i);
            }

            var transformedList = TransformNumbers(numbers, NumberCoverterFunc);

            foreach (var item in transformedList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }

        private static int NumberCoverterFunc(int number)
        {
            bool isDivBy3 = IsDivBy(number, 3);
            bool isDivBy5 = IsDivBy(number, 5);
            if (isDivBy3  && isDivBy5) return 35;
            if (isDivBy3) return 3;
            if (isDivBy5) return 5;
            return number;
        }

        private static bool IsDivBy(int number, int divider)
        {
            return number % divider == 0;
        }

        /// <summary>
        /// Return transformed list %3 -> 3, %5 -> 5 ... 
        /// </summary>
        /// <param name="numbers"></param>
        public static List<int> TransformNumbers(List<int> numbers, Func<int,int> numberCoverterFunc)
        {
            if(numbers == null)
            {
                return null; 
            }

            return numbers.Select(n => numberCoverterFunc(n)).ToList();            
        }
    }
}
