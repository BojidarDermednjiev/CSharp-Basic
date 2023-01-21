namespace _09._Fish_Tank
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int length = ReadLineInput();
            int width = ReadLineInput();
            int height = ReadLineInput();
            double percent = double.Parse(Console.ReadLine());
            int volumeAquarium = length * width * height;
            double volumeLitters = volumeAquarium * 0.001;
            double occupiedSpace = percent / 100;
            double neededLitters = volumeLitters * (1 - occupiedSpace);
            Console.WriteLine(neededLitters);
        }

        private static int ReadLineInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
