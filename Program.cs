namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int pages = 464;
                /* Question 1

                if (pages > 300)
                {
                    Console.WriteLine("Long Book");
                }
                else
                {
                    Console.WriteLine("Short Book");
                }

                Console.WriteLine();*/
                /* Question 2
                bool isAvailable = true;

                if (pages > 300 && isAvailable)
                {
                    Console.WriteLine("You can borrow this book");
                }

                Console.WriteLine();*/
                /* Question 3
                string title = "Refactoring";

                switch (title)
                {
                    case "Clean Code":
                        Console.WriteLine("Great choice!");
                        break;

                    case "Refactoring":
                        Console.WriteLine("Nice pick!");
                        break;

                    default:
                        Console.WriteLine("Never heard of it");
                        break;
                }

                Console.WriteLine();*/
                string[] books =
                {
            "Clean Code",
            "The Pragmatic Programmer",
            "Refactoring"
        };
                /* Question 4
                

                for (int i = 0; i < books.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + books[i]);
                }

                Console.WriteLine();*/
                /* Question 5
                int j = 0;

                while (j < books.Length)
                {
                    Console.WriteLine(books[j]);
                    j++;
                }

                Console.WriteLine();*/
                /* Question 6
                int k = 1;

                do
                {
                    Console.WriteLine("Checking book...");
                    k++;
                }
                while (k <= 3);

                Console.WriteLine();*/
                // Question 7
                foreach (string book in books)
                {
                    Console.WriteLine(book);
                }

                Console.WriteLine();
            }
        }
    }
}