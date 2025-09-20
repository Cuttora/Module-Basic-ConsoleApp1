namespace practice___Module_5._2
{
    internal class Program
    {
        /*static void ShowColors(string username = "Jane", params string[] favcolors)
        {
            Console.WriteLine("{0}, Ваши любимые цвета:", username);
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} лет\nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
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
            var (name, age) = ("Евгения", 27);

            Console.WriteLine("Моё имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }
            ShowColors();

        }*/
        //---------------------------------------------------------------
        static int[] GetArrayFromConsole(int num = 5)
        {
            int[] result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива {0} ", i+1);
                result[i] = int.Parse(Console.ReadLine());
            }    
            return result;

        }
        static int[] SortArray(int[] array)
        {
            int check = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int t = 0; t < array.Length; t++)
                {
                    if (array[i] < array[t])
                    {
                        check = array[i];
                        array[i] = array[t];
                        array[t] = check;

                    } 
                }

            }

            return array;
        }
        static void ShowArray(int[] array, bool CheckSorted = false)
        {
            var temp = array;
            if (CheckSorted)
            {
                temp = SortArray(temp);
            }
            Console.Write("Array: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole(10);
            ShowArray(array,true);
        }   
    }
}
