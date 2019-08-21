using System;

namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbe:");
            string input = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(input);
                int sum = 0;
                for (int i = 0; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }

                }
                Console.WriteLine(sum);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            
            Console.ReadKey();
        }
    }
}
