namespace _03._Sum_Prime_Non_Prime
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string input;
            int primeSum = default;
            int notPrimeSum = default;
            while ((input = Console.ReadLine()) != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                int simpleNumber = number / 2;
                bool isNotPrime = false;
                for (int i = 2; i <= simpleNumber; i++)
                    if (number % i == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                if (isNotPrime)
                {
                    notPrimeSum += number;
                    continue;
                }
                primeSum += number;
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeSum}");
        }
    }
}
