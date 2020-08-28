using System;

namespace Session02Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var number in inputArray)
            {
                Console.WriteLine("Värdet är " + number);
            }
        }
    }
}
