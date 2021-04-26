using System;

namespace Exercise52
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    private static void UserInput(IShape repository)
    {
        bool tryAgain;
        do
        {
            Console.Write("Please enter a new shape. 1 for square, 2 for triangle, 3 for circle, Q to quit: ");
            var input = Console.ReadLine();
            

            Console.Write($"So far you have saved, ({repository.GetAll()}).  Would you like to try again?");
            tryAgain = Console.ReadLine().Trim().Equals("y", StringComparison.OrdinalIgnoreCase);
        } while (tryAgain);

    }
