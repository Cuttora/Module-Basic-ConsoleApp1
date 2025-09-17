namespace cortege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.WriteLine("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            anketa.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Вас зовут {0}, Вам {1}",anketa.name, anketa.age);

        }
    }
}
