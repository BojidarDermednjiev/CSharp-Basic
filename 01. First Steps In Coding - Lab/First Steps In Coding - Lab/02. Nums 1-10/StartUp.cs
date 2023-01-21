namespace _02._Nums_1_10
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            PrintNumbers1TO10();
        }

        private static void PrintNumbers1TO10()
        {
            var dataForNumbers = new List<int>();
            for (int i = 1; i <= 10; i++)
                dataForNumbers.Add(i);
            Console.WriteLine(string.Join(Environment.NewLine, dataForNumbers));
        }
    }
}
