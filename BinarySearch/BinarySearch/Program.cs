using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = seq.Length;
            int value= 8;

            BinarySearch B = new BinarySearch(seq, n, value);
            Console.WriteLine(B.Search());
            Console.ReadKey();
        }
    }
}
