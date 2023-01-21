namespace _03._Deposit_Calculator
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            decimal deposit = decimal.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            decimal annualInterestRate = decimal.Parse(Console.ReadLine()); decimal sum = deposit + termOfDeposit * ((deposit * annualInterestRate / 100) / 12);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
