using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Wprowadź liczbę");
            ReturnNumber();
            Console.ReadKey();
        }

        public static int  StringToIntiger()
        {
            try
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                return number;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
           
        }

        public static  int ReturnNumber()
        {
            int sum = 0;
            while(StringToIntiger() > 0)
            {

                sum++; 
            }
            Console.WriteLine(sum);
            return sum;
        }
    }

}
