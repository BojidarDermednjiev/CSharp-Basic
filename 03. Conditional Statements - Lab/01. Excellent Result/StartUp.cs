namespace _01._Excellent_Result
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double assessment = double.Parse(Console.ReadLine());
            string output = assessment > 5.49 ? "Excellent!" : String.Empty;
            Console.WriteLine(output);
        }
    }
}
