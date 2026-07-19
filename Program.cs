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
                // Question 3
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

                Console.WriteLine();
            }
        }
    }
}