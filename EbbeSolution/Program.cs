using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbbeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal;
            GetNumber();
            NumberAnalyzer(tal);
        }

        private static int GetNumber()
        {
            Console.Write("Skriv et tal:");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static string NumberAnalyzer(int tal)
        {
            if (tal == 0) return "Tallet er nul";
            else if (tal > 0) return "Tallet er positivt";
            else return "Tallet er negativt";
        }
    }
}
