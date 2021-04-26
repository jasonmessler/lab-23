using System;

namespace exercise_75
{
    class Program
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Please enter a number: ");
            var numbers = Console.ReadLine();
            var num = double.Parse(numbers);
            Console.WriteLine($"The square root of {num} = { square( number)} ");
            Console.ReadLine();
        }
       public  double square(double number)
        {
            double error = 0.01; //define the precision of your result
            double s = number;

            while ((s - number / s) > error) //loop until precision satisfied 
            {
                s = (s + number / s) / 2;
            }
            return s;
        }
    }
}
