
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write("How old are you? ");
            var age = checked (byte.Parse(Console.ReadLine()));
            Console.Write("What is your date of birth (For example, 31.01.2001)? ");
            string dateOfBirth = Console.ReadLine();
            Console.WriteLine("Your name is {0} and age is {1}. And you were born on {2} ", name, age, dateOfBirth);

        }
    }
}
