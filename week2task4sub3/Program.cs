using System;

namespace week2task4sub3
{
    class Program
    {
        static void Main(string[] args)
        {//give lenght and width, calculate diagonal of the rectangle
            double lenght, width, squareSum, diagonal;

            Console.WriteLine("Give lenght of side of rectangle:");

            string sideA = Console.ReadLine();
            double.TryParse(sideA, out lenght);

            Console.WriteLine("Give width of side of rectangle:");

            string sideB = Console.ReadLine();
            double.TryParse(sideB, out width);

            squareSum = Math.Pow(lenght, 2) + Math.Pow(width, 2);
            diagonal = Math.Sqrt(squareSum);
            Console.WriteLine($"Diagonal lenght of recangle when sides value are: {lenght} and {width} is equal to {diagonal}");
            Console.ReadKey();
        }
    }
}
