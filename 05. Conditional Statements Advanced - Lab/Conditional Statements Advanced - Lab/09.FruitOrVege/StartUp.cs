namespace _09.FruitOrVege
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var dataForFruitAndVegetable = new Dictionary<string, List<string>>()
            {
                { "fruit", new List<string>()
                {
                    "banana",
                    "apple",
                    "kiwi",
                    "cherry",
                    "lemon",
                    "grapes"
                } },
                { "vegetable", new List<string>()
                {
                    "tomato",
                    "cucumber",
                    "pepper",
                    "carrot",
                } },
            };
            string readInputFromConsole = Console.ReadLine();
            string keyValuePair = dataForFruitAndVegetable.FirstOrDefault(x => x.Value.Contains(readInputFromConsole)).Key;
            try
            {
                string outputMessege = dataForFruitAndVegetable.ContainsKey(keyValuePair) ? $"{keyValuePair}" : "unknown";
                Console.WriteLine(outputMessege);
            }
            catch (Exception e)
            {

                Console.WriteLine("unknown");
            }
        }
    }
}
