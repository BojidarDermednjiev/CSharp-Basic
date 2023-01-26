namespace _01._Old_Books
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string favoriteBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int counterBook = default;
            bool isFounded = false;
            while (currentBook != "No More Books")
            {
                if (currentBook.Equals(favoriteBook))
                {
                    Console.WriteLine($"You checked {counterBook} books and found it.");
                    isFounded = true;
                    break;
                }
                counterBook++;
                currentBook = Console.ReadLine();
            }
            if (!isFounded)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counterBook} books.");
            }
        }
    }
}
