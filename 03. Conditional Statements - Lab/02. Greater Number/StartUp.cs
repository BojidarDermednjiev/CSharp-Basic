namespace _02._Greater_Number
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double firstNumberFromInput = double.Parse(Console.ReadLine());
            double secondNumberFromInput = double.Parse(Console.ReadLine());
            double biggerNumber = firstNumberFromInput > secondNumberFromInput ? firstNumberFromInput : secondNumberFromInput;
            Console.WriteLine(biggerNumber);
        }
    }
}
