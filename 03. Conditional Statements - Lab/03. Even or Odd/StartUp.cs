namespace _03._Even_or_Odd
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            string isItEvenOrOdd = readNumberFromConsole % 2 == 0 ? "even" : "odd";
            Console.WriteLine(isItEvenOrOdd);
        }
    }
}
