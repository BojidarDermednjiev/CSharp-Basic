namespace _03._AnimalType
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, string> animals = new Dictionary<string, string>()
            {
                {"dog", "mammal"},
                {"crocodile", "reptile"},
                {"tortoise", "reptile"},
                {"snake", "reptile"},
            };
            string typeOfAnimal = Console.ReadLine();
            string outputMessege = animals.ContainsKey(typeOfAnimal) ? animals.FirstOrDefault(x => x.Key == typeOfAnimal).Value : "unknown";
            Console.WriteLine(outputMessege);
        }
    }
}
