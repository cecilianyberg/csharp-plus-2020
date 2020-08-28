using System;
using System.Linq.Expressions;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            double?[] numberArray = new double?[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                try
                {
                    numberArray[i] = Convert.ToDouble(inputArray[i]);
                }
                catch (Exception)
                {
                    numberArray[i] = null;
                }
            }

            //Console.WriteLine("Värdet är " + number);

        }
    }
}
