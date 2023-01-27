namespace _02._Multiplication_Table
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            for (int firstNumber = 1; firstNumber <= 10; firstNumber++)
                for (int secondNumber = 1; secondNumber <= 10; secondNumber++)
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        }
    }
}
