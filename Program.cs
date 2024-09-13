using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parzysta_nieparzysta
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Program sprawdza, czy podana liczba jest parzysta czy nieparzysta");

                Console.WriteLine("Podaj liczbę: ");
                var liczba = CheckIfInt();

                if (liczba % 2 == 0)
                {
                    Console.WriteLine("Liczba jest parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba jest nieparzysta");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
                Console.ReadKey();
            }
        }
        private static int CheckIfInt()
        {
            var input = Console.ReadLine();
            if (!int.TryParse(input, out var number))
            {
                Console.WriteLine("Podana wartość nie jest liczbą");
                Console.WriteLine("Podaj liczbę: ");
                return CheckIfInt();
            }
            return number;
        }
    }
}
