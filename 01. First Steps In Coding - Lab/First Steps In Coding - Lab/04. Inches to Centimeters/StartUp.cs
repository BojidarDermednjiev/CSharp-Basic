namespace _04._Inches_to_Centimeters
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Action<double> output = centimeters => Console.WriteLine(centimeters);
            var inches = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).Sum(x => x * 2.54);
            output(inches);
        }
    }
}
