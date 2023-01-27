namespace _05._Special_Numbers
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
                for (int j = 1; j <= 9; j++)
                    for (int k = 1; k <= 9; k++)
                        for (int m = 1; m <= 9; m++)
                            if (number % i == 0 && number % j == 0 && number % k == 0 && number % m == 0)
                                Console.Write("" + i + j + k + m + " ");
        }
    }
}
