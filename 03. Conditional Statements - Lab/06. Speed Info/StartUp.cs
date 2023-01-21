namespace _06._Speed_Info
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            string rateSpeed = String.Empty;
            if (speed <= 10)
                rateSpeed = "slow";
            else if (speed > 10 && speed <= 50)
                rateSpeed = "average";
            else if (speed > 50 && speed <= 150)
                rateSpeed = "fast";
            else if (speed > 150 && speed <= 1000)
                rateSpeed = "ultra fast";
            else
                rateSpeed = "extremely fast";
            Console.WriteLine(rateSpeed);
        }
    }
}
