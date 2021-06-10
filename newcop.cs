using System;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main(string[] args)


        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double(Math.PI * radius * radius);

        }
        


    }
}
