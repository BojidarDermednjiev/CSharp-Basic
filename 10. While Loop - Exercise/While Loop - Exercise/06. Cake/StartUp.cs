namespace _06._Cake
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int cakePieces = width * lenght;
            while (input != "STOP")
            {
                cakePieces -= int.Parse(input);
                if (cakePieces <= 0)
                    break;
                input = Console.ReadLine();
            }
            if (cakePieces > 0)
                Console.WriteLine($"{cakePieces} pieces are left.");
            else
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
        }
    }
}
