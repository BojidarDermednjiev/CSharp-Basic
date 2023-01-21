namespace _04._Password_Guess
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const string CORRECTLYPASSWORD = "s3cr3t!P@ssw0rd";
            string readInput = Console.ReadLine();
            string isItCorrectOrNot = readInput == CORRECTLYPASSWORD ? "Welcome" : "Wrong password!";
            Console.WriteLine(isItCorrectOrNot);
        }
    }
}
