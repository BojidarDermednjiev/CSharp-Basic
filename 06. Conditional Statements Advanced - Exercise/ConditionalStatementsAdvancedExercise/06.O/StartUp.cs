namespace _06.O
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    int sum = numberOne + numberTwo;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{numberOne} + {numberTwo} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberOne} + {numberTwo} = {sum} - odd");
                    }
                    break;
                case '-':
                    int dif = numberOne - numberTwo;
                    if (dif % 2 == 0)
                    {
                        Console.WriteLine($"{numberOne} - {numberTwo} = {dif} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberOne} - {numberTwo} = {dif} - odd");
                    }
                    break;
                case '*':
                    int result = numberOne * numberTwo;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{numberOne} * {numberTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberOne} * {numberTwo} = {result} - odd");
                    }
                    break;
                case '/':
                    if (numberTwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberOne} by zero");
                    }
                    else
                    {
                        double division = (double)numberOne /* 1.0*/ / numberTwo;
                        Console.WriteLine($"{numberOne} / {numberTwo} = {division:f2}");
                    }
                    break;
                case '%':
                    if (numberTwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberOne} by zero");
                    }
                    else
                    {
                        int leftOver = numberOne % numberTwo;
                        Console.WriteLine($"{numberOne} % {numberTwo} = {leftOver}");
                    }
                    break;
            }
        }
    }
}
