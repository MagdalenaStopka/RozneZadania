using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz liczbę, którą chcesz spotęgować:");
            string input = Console.ReadLine();

            Console.WriteLine("Wprowadz wykładnik potęgi:");
            string inputPower = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int numberPower = Convert.ToInt32(inputPower);
            CountPower(number, numberPower);

            Console.WriteLine("");

            Console.WriteLine("Wprowadz liczbę, z której chcesz obliczyc silnię:");
            string inputFactorial = Console.ReadLine();
            int numberFactorial = Convert.ToInt32(inputFactorial);
            CountFactorial(numberFactorial);
            Console.ReadKey();
        }

        public static void CountPower(int a, int b)
        {
            int poweredNumber = 1;
            for (int i = 0; i < b; i++)
            {
                poweredNumber *= a;
            }
            Console.WriteLine("Wynik operacji: "+ poweredNumber);
        }

        public static void CountFactorial(int a)
        {
            int factorialNumber = 1;
            for (int i = a; i > 0; i--)
            {
                factorialNumber *= i;
            }
            Console.WriteLine("Wynik operacji: " + factorialNumber);
        }

    }
}
