namespace _03._Combinations
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int target = int.Parse(Console.ReadLine());
            int counterOfVariants = default;
            for (int firstNumber = 0; firstNumber <= target; firstNumber++)
                for (int secondNumber = 0; secondNumber <= target; secondNumber++)
                    for (int thirdNumber = 0; thirdNumber <= target; thirdNumber++)
                        if (firstNumber + secondNumber + thirdNumber == target)
                            counterOfVariants++;
            Console.WriteLine(counterOfVariants);
        }
    }
}
