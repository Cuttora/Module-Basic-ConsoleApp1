using System.Data;

namespace sorting_a_two_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int verse = 0;
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            for (int t = 0; t < arr.GetUpperBound(0) + 1; t++)
            {
                for (int y = 0; y < arr.GetUpperBound(1) + 1; y++)
                {
                    for (int i = 0; i < arr.GetUpperBound(1) + 1; i++)
                    {
                        if (arr[t,y] < arr[t,i])
                        {
                            verse = arr[t, y];
                            arr[t, y] = arr[t, i];
                            arr[t, i] = verse;
                        }
                    }
                }
            }


            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {

                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
