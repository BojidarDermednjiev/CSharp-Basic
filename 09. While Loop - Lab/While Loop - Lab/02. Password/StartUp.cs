namespace _02._Password
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (password == input)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
            }
        }
    }
}
