namespace Cortege_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, double age, string[] Favcolor) User;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                if (Console.ReadLine() == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }
                Console.WriteLine("Введите возраст пользователя");
                User.age = double.Parse(Console.ReadLine());
                User.Favcolor = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int t = 0; t < User.Favcolor.Length; t++)
                {
                    User.Favcolor[t] = Console.ReadLine();
                }
            }
            

        }
    }
}
