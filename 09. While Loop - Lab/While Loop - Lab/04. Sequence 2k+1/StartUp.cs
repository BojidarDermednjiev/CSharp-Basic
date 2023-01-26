namespace _04._Sequence_2k_1
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int target, number;
            target = int.Parse(Console.ReadLine());
            number = 1;
            Sequence2K1(target, number);
        }

        private static void Sequence2K1(int target, int number)
        {
            if (number > target)
                return;
            Console.WriteLine(number);
            Sequence2K1(target, number = number * 2 + 1);
        }
    }
}
