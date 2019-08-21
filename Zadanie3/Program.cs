using System;
using System.Linq;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[9];
            TakeRandomNumbers(arrayOfNumbers);
            DisplayArray(arrayOfNumbers);
            Array.Reverse(arrayOfNumbers);
            Console.Write("," + " ");
            DisplayArray(arrayOfNumbers);
           
            Console.ReadKey();
        }

        public static void DisplayArray(int[] arrayOfNumbers)
        {
            foreach (var number in arrayOfNumbers)
            {
                if (number == arrayOfNumbers.Last())
                {
                    Console.Write(number);
                }
                else
                {
                    Console.Write(number.ToString() + " ");
                }
            }
        }
        public static void TakeRandomNumbers(int[] numbersArray)
        {
            Random random = new Random();
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = random.Next(1, 100);

            }
        }
    }
}
