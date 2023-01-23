namespace _04.PersonalTit
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int counter = default(int);
            if (age >= 16 && gender == 'm')
                counter += 1;
            else if (age < 16 && gender == 'm')
                counter += 2;
            else if (age >= 16 && gender == 'f')
                counter += 3;
            else if (age < 16 && gender == 'f')
                counter += 4;

            Dictionary<int, string> selection = new Dictionary<int, string>()
            {
                {1, "Mr."},
                {2, "Master"},
                {3, "Ms."},
                {4, "Miss"},
            };
            string outputMessege = selection[counter];
            Console.WriteLine(outputMessege);
        }
    }
}
