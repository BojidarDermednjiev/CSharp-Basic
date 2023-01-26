namespace _01._Read_Text
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            while (true)
            {
                string readText = Console.ReadLine();
                if (readText == "Stop")
                    break;
                Console.WriteLine(readText);
            }
        }
    }
}
