namespace _05._Character_Sequence
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
                Console.WriteLine(text[i]);
        }
    }
}
