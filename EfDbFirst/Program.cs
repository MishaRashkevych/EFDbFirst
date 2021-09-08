using System;

namespace EfDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("________________________________________________________");
                Console.WriteLine("Press 'E' to exit or any key to repeat");
                if (Console.ReadKey().Key == ConsoleKey.E) break;
            } while (true);
        }
    }
}
