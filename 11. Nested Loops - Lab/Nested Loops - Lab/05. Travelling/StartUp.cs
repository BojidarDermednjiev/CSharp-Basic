namespace _05._Travelling
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string destination;

            while ((destination = Console.ReadLine()) != "End")
            {
                double cost = double.Parse(Console.ReadLine());
                double totalSaving = default;
                while (totalSaving < cost)
                {
                    double saving = double.Parse(Console.ReadLine());
                    totalSaving += saving;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
