using System;

namespace practice___Module_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
             var str = Console.ReadLine();

             Console.WriteLine("Укажите глубину эха");
             var deep = int.Parse(Console.ReadLine());

             Echo(str, deep);

        }
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static void Echo(string phrase, int deep) 
        {
            var modif = phrase;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);


            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}
