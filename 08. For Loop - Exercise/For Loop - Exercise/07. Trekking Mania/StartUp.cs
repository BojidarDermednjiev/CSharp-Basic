namespace _07._Trekking_Mania
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int countOfGroupes = int.Parse(Console.ReadLine());
            double climbingMusalla = default(double);
            double climbingMontBlanc = default(double);
            double climbingKilimanjaro = default(double);
            double climbingК2 = default(double);
            double climbingEverest = default(double);
            double totalPeople = default(double);
            for (int i = 0; i < countOfGroupes; i++)
            {
                int numberOfPeopleInGroup = int.Parse(Console.ReadLine());
                totalPeople += numberOfPeopleInGroup;
                if (numberOfPeopleInGroup <= 5)
                    climbingMusalla += numberOfPeopleInGroup;
                else if (numberOfPeopleInGroup >= 6 && numberOfPeopleInGroup <= 12)
                    climbingMontBlanc += numberOfPeopleInGroup;
                else if (numberOfPeopleInGroup >= 13 && numberOfPeopleInGroup <= 25)
                    climbingKilimanjaro += numberOfPeopleInGroup;
                else if (numberOfPeopleInGroup >= 26 && numberOfPeopleInGroup <= 40)
                    climbingК2 += numberOfPeopleInGroup;
                else if (numberOfPeopleInGroup >= 41)
                    climbingEverest += numberOfPeopleInGroup;
            }
            Console.WriteLine($"{((climbingMusalla / totalPeople) * 100):f2}%");
            Console.WriteLine($"{((climbingMontBlanc / totalPeople) * 100):f2}%");
            Console.WriteLine($"{((climbingKilimanjaro / totalPeople) * 100):f2}%");
            Console.WriteLine($"{((climbingК2 / totalPeople) * 100):f2}%");
            Console.WriteLine($"{((climbingEverest / totalPeople) * 100):f2}%");
        }
    }
}
