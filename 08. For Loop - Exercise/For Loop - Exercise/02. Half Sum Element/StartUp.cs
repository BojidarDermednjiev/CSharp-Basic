namespace _02._Half_Sum_Element
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int countOfReadNum = int.Parse(Console.ReadLine());
            int sum = default;
            int maxNumber = int.MinValue;
            for (int i = 0; i < countOfReadNum; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNumber)
                    maxNumber = num;
            }
            string outputMessege = sum - maxNumber == maxNumber ? "Yes" + Environment.NewLine + $"Sum = {sum - maxNumber}" : "No" + Environment.NewLine + $"Diff = {Math.Abs(maxNumber - (sum - maxNumber))}";
            Console.WriteLine(outputMessege);
        }
    }
}
