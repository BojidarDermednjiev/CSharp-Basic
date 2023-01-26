namespace _04._Clever_Lily
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int ageOfTheLily = int.Parse(Console.ReadLine());
            decimal priceForWashingMachine = decimal.Parse(Console.ReadLine());
            decimal pricePerToy = decimal.Parse(Console.ReadLine());
            int countOfToys = default(int);
            decimal sum = default(decimal);
            int countOfBrotherTakeMoney = default(int);
            int index = 1;
            for (int currentAge = 1; currentAge <= ageOfTheLily; currentAge++)
            {
                if (currentAge % 2 != 0)
                    countOfToys++;
                else 
                {
                    sum += 10 * index++;
                    countOfBrotherTakeMoney++;
                }
            }
            sum += countOfToys * pricePerToy - countOfBrotherTakeMoney * 1.0m;
            string outputMessage = sum - priceForWashingMachine >= 0 ? $"Yes! {(sum - priceForWashingMachine):f2}" : $"No! {Math.Abs((sum - priceForWashingMachine)):f2}";
            Console.WriteLine(outputMessage);
        }
    }
}
