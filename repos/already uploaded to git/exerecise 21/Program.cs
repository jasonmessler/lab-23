using System;
using System.Collections.Generic;

namespace exerecise_21
{
    class Program
    {
        private static readonly string wordYOrN;

        static void Main(string[] args)
        {
            string contYOrN;
            string[] myArray = new string[5];

            do  //new sentence/start over loop
            {
                Console.Write("Hello! Please enter a word: ");
                myArray[0] = Console.ReadLine();




                for (int i = 1; i < myArray.Length; i++) //adding to string loop
                {
                    string wordYOrN;
                    do
                    {
                        Console.Write("Would you like to enter another word (y/n)? ");
                        wordYOrN = Console.ReadLine();
                        Console.Write("Enter a word: ");
                        myArray[i] = Console.ReadLine();
                        string.Join(" ", myArray);

                    } while (wordYOrN == "y");
                }
                foreach (string item in myArray)
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine(myArray);
                Console.WriteLine("Would you like to continue (y/n)? ");
                contYOrN = Console.ReadLine();
            } while (contYOrN == "y");


            Console.WriteLine();
            Console.WriteLine("Thanks for Playing! Goodbye!");  // goodbye statement
            Console.ReadLine();

        }
    }
}           