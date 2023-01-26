namespace _05._Salary
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int numberOfTaps = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTaps; i++)
            {
                string website = Console.ReadLine();
                switch (website)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                    default:
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
                Console.WriteLine(salary);
        }
    }
}
