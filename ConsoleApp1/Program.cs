using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double radius = 2.5;

            double area = pi * (radius * radius);

            Console.WriteLine($"Area equals to: {area}");
        }
    }
}
