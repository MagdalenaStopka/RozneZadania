using System;
using System.Linq;

namespace Zadanie4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ile elementów ma mieć tablica:");
            int numberOfElements = StringToIntiger();
            int[] arrayOfNumbers = new int[numberOfElements];


            PutNumbersIntoArray(numberOfElements, arrayOfNumbers);
            DisplayArray(arrayOfNumbers);
            DisplayResult(numberOfElements,arrayOfNumbers);
            

            Console.ReadKey();
            
        }
        public static int StringToIntiger()
        {
            try
            {
                string input = Console.ReadLine();
                int numberOfElements = Convert.ToInt32(input);
                return numberOfElements;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }
        public static void PutNumbersIntoArray(int numberOfElements, int[] arrayOfNumbers)
        {
            Console.WriteLine("Wprowadź kolejno liczby do tablicy:");
            for (int i = 0; i < numberOfElements; i++)
            {
                string inputNUmber = Console.ReadLine();
                int number = Convert.ToInt32(inputNUmber);
                arrayOfNumbers[i] = number;
                
            }
        }
        public static void DisplayArray(int[] arrayOfNumbers)
        {
            Console.WriteLine("Tablica:");
            foreach (int number in arrayOfNumbers)
            {
                Console.Write(number.ToString() + " ");
            }
            Console.WriteLine("");
        }
        public static void DisplayResult(int numberOfElements, int[] arrayOfNumbers)
        {
            CountMedian(numberOfElements, arrayOfNumbers);
            Array.Sort(arrayOfNumbers);
            Console.WriteLine("Srednia z liczb w tablicy " + arrayOfNumbers.Average());
            Console.WriteLine("Najmniejsza liczba w tablicy: " + arrayOfNumbers.First());
            Console.WriteLine("Największa liczba w tablicy: " + arrayOfNumbers.Last());
            
            
        }
        public static void CountMedian(int numberOfElements, int[] arrayOfNumbers)

        {
            double median;
            int indexInTheMiddle = numberOfElements / 2;
            if(numberOfElements%2== 0)
            {
                median = (Convert.ToDouble(arrayOfNumbers[indexInTheMiddle]) + Convert.ToDouble(arrayOfNumbers[indexInTheMiddle - 1]))/2;
                Console.WriteLine("Mediana z liczb w tablicy " + median);
            }
            else
            {
                median = arrayOfNumbers.ElementAt(indexInTheMiddle);
                Console.WriteLine("Mediana z liczb w tablicy " + median );
            }
        }

    }
}
