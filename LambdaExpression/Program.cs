using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Action<int> printodd = x =>
            {
                var square = x * x;
                var cube = x * x * x;
                Console.WriteLine($"{x} : {square} , {cube}");
            };

            Func<int, bool> oddcheck = x => x%2!=0;

            var oddnumbers = numbers.Where(oddcheck).ToList();

            oddnumbers.ForEach(printodd);

            Console.ReadLine();

        }
    }
}
