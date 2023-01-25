namespace _10._Odd_Even_Sum
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int oddSum = default, evenSum = default;

            for (int i = 0; i < count; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    evenSum += currNumber;
                else
                    oddSum += currNumber;
            }
            string outputMessege = evenSum == oddSum ? "Yes" + Environment.NewLine + $"Sum = {oddSum}" : "No" + Environment.NewLine + $"Diff = {Math.Abs(oddSum - evenSum)}";
            Console.WriteLine(outputMessege);
        }
    }
}
