namespace _07._Min_Number
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number < minNumber)
                    minNumber = number;
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
