namespace _02._Bonus_Score
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberfromConsole = int.Parse(Console.ReadLine());
            double bonusPoints = default;
            if (readNumberfromConsole <= 100)
                bonusPoints = 5;
            else if (readNumberfromConsole > 100 && readNumberfromConsole <= 1000)
                bonusPoints = readNumberfromConsole * 0.2;
            else if (readNumberfromConsole > 1000)
                bonusPoints = readNumberfromConsole * 0.1;
            if (readNumberfromConsole % 2 == 0)
                bonusPoints += 1;
            else if (readNumberfromConsole % 10 == 5)
                bonusPoints += 2;
            Console.WriteLine(bonusPoints);
            Console.WriteLine(readNumberfromConsole + bonusPoints);
        }
    }
}
