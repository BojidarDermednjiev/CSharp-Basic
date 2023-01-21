namespace _05._Number_100To200
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readFromConsole = int.Parse(Console.ReadLine());
            string output = String.Empty;
            if (readFromConsole < 100)
                output = "Less than 100";
            else if (readFromConsole >= 100 && readFromConsole <= 200)
                output = "Between 100 and 200";
            else if (readFromConsole > 200)
                output = "Greater than 200";
            Console.WriteLine(output);
        }
    }
}
