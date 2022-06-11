using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int WinNum = r.Next(0, 100);

            bool Win = false;

            do
            {
                Console.WriteLine("Guess A Number Between 0 To 100");

                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > WinNum)
                {
                    Console.WriteLine("To High !! Guess Lower ...");
                }
                else if (i < WinNum)
                {
                    Console.WriteLine("To Low !! Guess Higher ...");
                }
                else if (i == WinNum)
                {
                    Console.WriteLine("You Win !!!");
                    Win = true;
                }
                Console.WriteLine();

            } while (Win == false);

            Console.WriteLine("Thanks For Playing The Game :)");
            Console.WriteLine("Press Any Key For Quit");
            Console.ReadKey(true);
        }
    }
}
