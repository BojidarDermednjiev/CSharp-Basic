namespace _03._Rectangle_Area
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Action<int> print = area => Console.WriteLine(area);
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            print(firstNumber * secondNumber);
        }
    }
}
