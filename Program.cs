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
                // Question 2
                bool isAvailable = true;

                if (pages > 300 && isAvailable)
                {
                    Console.WriteLine("You can borrow this book");
                }

                Console.WriteLine();
            }
        }
    }
}