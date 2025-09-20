using System.Globalization;
using System.Net.Http.Headers;

namespace practice___Module_5._3
{
    internal class Program
    {
        class MainClass
        {
            static void SortArray(int[] array, out int[] sorteddesc, out int[] sortedasc)
            {
                sorteddesc = SortArrayDesc(array);
                sortedasc = SortArrayAsc(array);
            }
            static int[] SortArrayDesc(int[] array)
            {
                int check = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int t = 0; t < array.Length; t++)
                    {
                        if (array[i] > array[t])
                        {
                            check = array[i];
                            array[i] = array[t];
                            array[t] = check;

                        }
                    }

                }

                return array;
            }
            static int[] SortArrayAsc(int[] array)
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
            public static void Main(string[] args)
            {

            }



        }
    }
}
