namespace Timer
{
    using System;
    using System.Threading;

    public class StartUp
    {
        static string Password = "CampusX23";
        static int incorrectInputsPasswordCounter = 1;
        static Action<string> write = outputMessage => Console.Write(outputMessage);
        static Action<string> writeLine = outputMessage => Console.WriteLine(outputMessage);
        static int maxCapacityOfTry = 3;
        static bool isHaveLetter = false;
        static bool isHaveUpperCase = false;
        static bool isHaveDigits = false;
        static void Main()
        {
            Engine();
        }
        private static void Engine()
        {
            if (incorrectInputsPasswordCounter == 1)
                Branch();
            else
                CounterForLeftTry();
            if (incorrectInputsPasswordCounter <= maxCapacityOfTry)
                PrintEntryYourPassword();

            string inputLineFromConsole = Console.ReadLine();
            if (inputLineFromConsole == Password)
            {
                write("Welcome!");
                return;
            }
            if (inputLineFromConsole.Length < 6)
                writeLine(" --> Minimum 6 symbols");
            if (string.IsNullOrWhiteSpace(inputLineFromConsole))
                writeLine(" --> You cannot give a white space or empty input!");
            foreach (var symbol in inputLineFromConsole)
            {
                if (char.IsLetter(symbol))
                    isHaveLetter = true;
                if (char.IsDigit(symbol))
                    isHaveDigits = true;
                if (char.IsUpper(symbol))
                    isHaveUpperCase = true;
            }
            if (!isHaveLetter)
                writeLine(" --> Entry is inccorect!");
            if (!isHaveUpperCase)
                writeLine(" --> Word doesn't have Upper case!!!");
            if (!isHaveDigits)
                writeLine(" --> Word doesn't have digit!");

            if (incorrectInputsPasswordCounter == maxCapacityOfTry)
            {
                Console.WriteLine("You can try again after 10 seconds!");
                for (int currentSecond = 10; currentSecond >= 1; currentSecond--)
                {
                    writeLine($"{currentSecond} sec.");
                    Thread.Sleep(1000);
                }
                incorrectInputsPasswordCounter = default(int);
                writeLine("Time's up! You can try Again!");
            }
            isHaveLetter = false;
            isHaveUpperCase = false;
            incorrectInputsPasswordCounter++;
            Engine();//--> Recursion
        }
        private static void Branch()
             => write($"Starting point of tries: {maxCapacityOfTry}. ");
        private static void CounterForLeftTry()
             => write($"Left try: {(maxCapacityOfTry + 1) - incorrectInputsPasswordCounter}. ");
        private static void PrintEntryYourPassword()
             => write("Entry you password: ");
    }
}
