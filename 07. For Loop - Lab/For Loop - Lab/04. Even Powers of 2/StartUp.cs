namespace _04._Even_Powers_of_2
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            int num = default(int);
            for (int i = 0; i <= readNumberFromConsole; i += 2)
            {
                //Console.WriteLine($"2^{i} = {num}");
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}
