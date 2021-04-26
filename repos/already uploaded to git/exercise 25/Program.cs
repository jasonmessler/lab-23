using System;

namespace exercise_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string yOrN;
            do
            {
                Console.Write("Enter a sentence: ");
                Console.ReadLine();
                Console.WriteLine("Would you like to continue (y/n)");
                yOrN = Console.ReadLine();

            } while (yOrN == "y" || yOrN == "Y");

            Console.WriteLine();
            Console.WriteLine("Goodbye!");

            
        } 
    }
}
