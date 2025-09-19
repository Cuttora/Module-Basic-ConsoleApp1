namespace practice
{
    internal class Program
    {
        // 5.1.5
        /*static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            string color = Console.ReadLine();

            
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;

        }

        static void Main(string[] args)
        {
            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }
            Console.WriteLine("Ваши любимые цветы: ");
            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine(favcolors[i]);
            }
            
        }*/
        //--------------------------------------------------------------------------------------
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int check;

            for (int i = 0; i < result.Length; i++)
            {
                for (int t = 0; t < result.Length; t++)
                {
                    if (result[i] < result[t])
                    {
                        check = result[i];
                        result[i] = result[t];
                        result[t] = check;
                    }
                }
            }
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            return result;
        }
        static void Main(string[] args)
        {
           int[] array = GetArrayFromConsole();
        }
    }

}

