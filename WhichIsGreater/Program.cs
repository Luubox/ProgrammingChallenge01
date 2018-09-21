using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichIsGreater
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
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            int secondInput = Convert.ToInt32(Console.ReadLine());

            //if (firstInput == secondInput)
            //{
            //    Console.WriteLine($"The number {firstInput} is the same as {secondInput}");
            //    NumberChecker();
            //}
            if (firstInput > secondInput)
            {
                Console.WriteLine($"The number {firstInput} is greater than {secondInput}");
                NumberChecker();
            }
            else /* (firstInput < secondInput)*/
            {
                Console.WriteLine($"The number {secondInput} is greater than {firstInput}");
                NumberChecker();
            }
        }
    }
}
