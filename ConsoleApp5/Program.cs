using System.Collections.Immutable;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int versa;
   
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int t = 0; t < arr.Length; t++)
                {
                    if (arr[i] < arr[t])
                    {
                        versa = arr[i]; 
                        arr[i] = arr[t];
                        arr[t] = versa; 
                    }

                }

            }







            foreach (var item in arr)
            {
                Console.Write(item);
            }


        }
    }
}
