using System;
using System.Linq;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz liczbę:");
            string input = Console.ReadLine();
            CountZero(input);
            PositionOfZero(input);

            
            Console.ReadKey();
        }

        public static void CountZero(string a)
        {
            int count = 0;

            foreach (char number in a)
            {
                if (number == '0')
                {
                    count++;
                }
            }

            Console.WriteLine("Liczba zer w wprowadzonej liczbie: "+ count);
        }

        public static void PositionOfZero(string a)
        {
            int position = 0;
             int count = 0;
            int index = 0;

            Console.WriteLine("Pozycja zer w liczbie: ");

            foreach (char number in a)
            {
                count++;
                if (number == '0')
                {
                    index = a.NextIndexOf('0');
                    position = index;
                    if (index == a.LastIndexOf('0'))
                    {
                        Console.Write(position);
                    }
                    else
                    {
                        Console.Write(position.ToString() + ", ");
                    }
                }
            }
        }
    }
}