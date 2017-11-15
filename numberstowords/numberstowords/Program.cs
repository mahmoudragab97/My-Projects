using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberstowords
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Please enter a number from 0 to 999");
            int digit = Convert.ToInt32(Console.ReadLine());
            string[] numbers = new string[11]
            {
                "zero","one","two","three","four","five","six","seven","eight","nine","ten"
            };
            string[] numbers2 = new string[9]
            {
               "eleven","twelve","thirteen","fourteen","fifeteen","sixteen","seventeen","eighteen","nineteen"
            };

            string[] numbers3 = new string[8]
            {
              "twenty","thirty","forty","fifty","sixty","seventy","eighty","ninty"
            };
            if (digit <= 10)
            {
                Console.WriteLine(numbers[digit]);
                Console.WriteLine();
                goto start;
            }
            else if (digit > 10 && digit < 20)
            {
                Console.WriteLine(numbers2[(digit % 10) - 1]);
                Console.WriteLine();
                goto start;
            }
            else if (digit > 20 && digit < 100)
            {
                Console.WriteLine(numbers3[((digit % 100) / 10) - 2] + " " + numbers[(digit % 10)]);
                Console.WriteLine();
                goto start;
            }
            else if (digit > 100 && digit < 1000)
            {
                if (((digit % 100) % 10) == 0)
                {
                    Console.WriteLine(numbers[(digit / 100)] + " hundred " + numbers3[((digit % 100) / 10) - 1]);
                }
                else
                {
                    Console.WriteLine(numbers[(digit / 100)] + " hundred " + " and " + numbers3[((digit % 100) / 10) - 2] + " " + numbers[((digit % 100) % 10)]);
                    Console.WriteLine();
                    goto start;
                }
                Console.ReadLine();
            }
        }
    }
}
