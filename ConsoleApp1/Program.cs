namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Leonid";
            Console.WriteLine(MyName);
            

            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне 27 лет");
            Console.WriteLine("\tMy name is \n Leonid");
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");

            Console.ReadKey();
        }
    }
}