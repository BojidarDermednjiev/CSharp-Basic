namespace _01._Numbers_Ending_in_7
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            for (int currentNumber = 1; currentNumber <= 1000; currentNumber++)
                if (currentNumber % 10 == 7)
                    Console.WriteLine(currentNumber);
        }
    }
}
