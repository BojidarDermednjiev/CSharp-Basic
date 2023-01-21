namespace _01._Hello_SoftUni
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Action<string> prind = messege => Console.WriteLine(messege);
            var helloSoftUni = "Hello SoftUni";
            prind(helloSoftUni);
        }
    }
}
