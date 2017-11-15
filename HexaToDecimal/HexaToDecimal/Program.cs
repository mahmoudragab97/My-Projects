using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("please enter a hexadecimal number");
            string hexa = Console.ReadLine();
            int decimalout = int.Parse(hexa, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(decimalout);
            Console.ReadLine();
            goto Start;
        }
    }
}
