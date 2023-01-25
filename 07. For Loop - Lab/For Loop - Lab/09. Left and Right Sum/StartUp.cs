namespace _09._Left_and_Right_Sum
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                leftSum += current;
            }

            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                rightSum += current;
            }

            if (rightSum == leftSum)
                Console.WriteLine($"Yes, sum = {leftSum}");
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
                ////int diff = leftSum - rightSum;
                //if (diff < 0)
                //{
                //    diff = diff * -1;
                //}
                //Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
