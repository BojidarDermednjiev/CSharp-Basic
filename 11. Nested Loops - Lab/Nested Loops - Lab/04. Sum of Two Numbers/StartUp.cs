namespace _04._Sum_of_Two_Numbers
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = default;
            bool isMagicNumber = false;
            for (int x = firstNumber; x <= secondNumber; x++)
            {
                for (int y = firstNumber; y <= secondNumber; y++)
                {
                    counter++;
                    if (x + y == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x} + {y} = {magicNumber})");
                        isMagicNumber = true;
                        break;
                    }
                }
                if (isMagicNumber)
                    break;
            }
            if (!isMagicNumber)
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
