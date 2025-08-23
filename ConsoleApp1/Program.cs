namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Leonid";
            int MyAge = 19;
            bool HaveIApet = true;
            double MyShoeSize = 42.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is {0}",MyAge);
            Console.WriteLine($"Do I have a pet? {HaveIApet}");
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.ReadKey();
        }
    }
}