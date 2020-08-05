using Microsoft.VisualBasic;
using System;
using System.Data;

namespace week2task4sub5
{
    class Program
    {
        static void Main(string[] args)
        {//implementing data by user into the console
            string name, surname, email;
            long phoneNo, ordinalNo;
            double weight, height;
            DateTime dateOfgitCreation;

            Console.WriteLine("Hello!!! \r\nPlease type neccessary data into app");
            
            Console.WriteLine("Your name, please:");
            name = Console.ReadLine();

            Console.WriteLine("Your surname, please:");
            surname = Console.ReadLine();

            Console.WriteLine("Your email, please:");
            email = Console.ReadLine();

            Console.WriteLine("Type in your phone number, please:");
            phoneNo = long.Parse(Console.ReadLine());

            Console.WriteLine("Type in your ordinal number, please:");
            ordinalNo = long.Parse(Console.ReadLine());

            Console.WriteLine("It's time to add your weight:");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("This time add your height, please:");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, add date of your GitHub establishing, please use ths particulare date format YYYY-MM-DD :");
            dateOfgitCreation = DateTime.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
