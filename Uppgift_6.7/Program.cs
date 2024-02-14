using System;
namespace Uppgift_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in tal att primkollas");
            Console.WriteLine(ÄrPrimt(int.Parse(Console.ReadLine())));
        }
        /// <summary>
        /// Kollar om ett tal är primt
        /// </summary>
        /// <param name="tal">Talet som ska kollas</param>
        /// <returns>Om talet är primt eller ej</returns>
        static bool ÄrPrimt(int tal)
        {
            if (tal == 1)
            {
                return false;
            }

            for (int i = 2; i <= tal/2; i++)
            {
                if (tal % i == 0)
                {
                    return false;
                }
            }
           
            return true;
        }
    }
}