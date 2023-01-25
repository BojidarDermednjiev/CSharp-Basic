namespace _03._Numbers_1N_with_Step_3
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= number; currentNumber += 3)
                Console.WriteLine(currentNumber);
        }
    }
}
