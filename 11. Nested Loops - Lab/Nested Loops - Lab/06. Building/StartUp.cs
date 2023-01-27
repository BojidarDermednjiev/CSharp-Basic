namespace _06._Building
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int florsCount = int.Parse(Console.ReadLine());
            int roomsCount = int.Parse(Console.ReadLine());
            for (int floor = florsCount; floor >= 1; floor--)
            {
                for (int room = 0; room < roomsCount; room++)
                {
                    if (floor == florsCount)
                        Console.Write($"L{floor}{room} ");
                    else if (floor % 2 == 0)
                        Console.Write($"O{floor}{room} ");
                    else
                        Console.Write($"A{floor}{room} ");
                }
                Environment.NewLine.Trim();
            }
        }
    }
}
