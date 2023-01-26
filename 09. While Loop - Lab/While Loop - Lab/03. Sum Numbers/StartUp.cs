namespace _03._Sum_Numbers
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int targetSum, sum;
            targetSum = int.Parse(Console.ReadLine());
            sum = default;
            sum = SumNum(targetSum, sum);
            Console.WriteLine(sum);
        }
        private static int SumNum(int targetSum, int sum)
        {
            if (targetSum <= sum)
                return sum;
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            return SumNum(targetSum, sum += readNumberFromConsole);
        }
    }
}
