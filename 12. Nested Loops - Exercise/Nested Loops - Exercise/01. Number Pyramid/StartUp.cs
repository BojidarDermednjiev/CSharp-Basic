namespace _01._Number_Pyramid
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int current = 1;
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(current + " ");
                    current++;
                    if (current > number)
                        return;
                }
                Console.WriteLine();
            }
        }
    }
}
