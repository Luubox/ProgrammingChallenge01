using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenge01
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberChecker();
            Console.ReadKey();
        }

        private static void NumberChecker()
        {
            Console.WriteLine("Please enter a number:");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber > 0)
            {
                Console.WriteLine($"The number {inputNumber} is greater than 0");
                NumberChecker();
            }
            if (inputNumber < 0)
            {
                Console.WriteLine($"The number {inputNumber} is less than 0");
                NumberChecker();
            }
            else
            {
                Console.WriteLine($"The number {inputNumber} is equal to 0");
                NumberChecker();
            }
        }
    }
}
