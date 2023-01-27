namespace _02._Equal_Sums_Even_Odd_Position
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int oddNumber = default;
                int evenNumber = default;
                string current = i.ToString();
                for (int index = 0; index < current.Length; index++)
                {
                    int currentDigit = int.Parse(current[index].ToString());
                    if (index % 2 == 0)
                        oddNumber += currentDigit;
                    else
                        evenNumber += currentDigit;
                }
                if (oddNumber == evenNumber)
                    Console.Write($"{current} ");
            }
        }
    }
}
