namespace _10.InvalidNum
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            bool isItValid = false;
            if(readNumberFromConsole >= 100 && readNumberFromConsole <= 200 || readNumberFromConsole == 0)
                isItValid = true;
            string outputMessege = isItValid ? String.Empty : "invalid";
            Console.WriteLine(outputMessege);
         }
    }
}
