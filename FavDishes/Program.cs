using System.Linq.Expressions;

namespace FavDishes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string[] FavDishes) User;
            User.FavDishes = new string [5];
            Console.WriteLine("What is your name? ");
            User.name = Console.ReadLine();
            Console.WriteLine("What is your favorite dishes(TOP 5): ");
            for (int i = 0; i < User.FavDishes.Length; i++)
            {
                Console.WriteLine("TOP {0}" , i + 1);
                User.FavDishes[i] = Console.ReadLine();
            }
            
        }

    }
}
