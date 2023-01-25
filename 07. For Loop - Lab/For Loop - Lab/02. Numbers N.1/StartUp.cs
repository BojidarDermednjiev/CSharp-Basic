namespace _02._Numbers_N._1
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNumber = number; currentNumber >= 1; currentNumber--)
                Console.WriteLine(currentNumber);
        }
    }
}
