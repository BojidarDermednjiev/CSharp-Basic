namespace _07._Moving
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());
            int cubicMeters = widthFreeSpace * lengthFreeSpace * heightFreeSpace;
            int counter = default;
            bool isItEnoughSpace = true;
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Done")
            {
                counter += int.Parse(inputLine);
                if (counter >= cubicMeters)
                {
                    isItEnoughSpace = false;
                    break;
                }
            }
            string outputMessage = !isItEnoughSpace ? ($"No more free space! You need {Math.Abs(counter - cubicMeters)} Cubic meters more.") : $"{cubicMeters - counter} Cubic meters left.";
            Console.WriteLine(outputMessage);
        }
    }
}
