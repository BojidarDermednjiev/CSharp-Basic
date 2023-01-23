namespace _06.NumberInRan
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Action<string> print = messege => Console.WriteLine(messege); 
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            bool isItOnInterval = false;
            if(readNumberFromConsole >= -100 && readNumberFromConsole <= 100 && readNumberFromConsole != 0)
                isItOnInterval = true;
            string outputMessege = isItOnInterval ? "Yes" : "No";
            print(outputMessege);
        }
    }
}
