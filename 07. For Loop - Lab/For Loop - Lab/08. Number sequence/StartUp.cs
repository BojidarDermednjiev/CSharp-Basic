namespace _08._Number_sequence
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int smallest = int.MaxValue;
            for (int i = 0; i < count; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (currNum > biggest)
                {
                    biggest = currNum;
                }

                if (currNum < smallest)
                {
                    smallest = currNum;
                }
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
