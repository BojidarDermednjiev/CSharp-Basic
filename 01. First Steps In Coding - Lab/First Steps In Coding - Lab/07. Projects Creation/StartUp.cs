namespace _07._Projects_Creation
{
    using System;
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string nameOfArhitect = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {nameOfArhitect} will need {projects * 3} hours to complete {projects} project/s.");
        }
    }
}
