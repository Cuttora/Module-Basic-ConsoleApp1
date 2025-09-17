namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count1 = 0;
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            //1 способ
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1 ; j++)
                {
                    if (arr[i, j] >= 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            //2 способ 
            foreach (var item in arr)
            {
                if (item >= 0 )
                {
                    count1++;

                }

            }
            Console.WriteLine(count1);
        }
    }
}
