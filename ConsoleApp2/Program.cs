namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет?");
            string age = Console.ReadLine();
            Console.WriteLine("Какое у Вас хобби?");
            string hobby = Console.ReadLine();

            Console.WriteLine($"\n\nЗдравствуйте, {name}. Благодаря Вашим ответам мы узнали о Вас много нового!)" + "\n- - - - - - - -" + "\n Возраст: " + age
                + "\n Увлечение: {0}" + "\n- - - - - - - -", hobby);

        }

    }
}