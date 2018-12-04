using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = seq.Length;
            int value = 7;
            int begin = 0;

            BinarySearch B = new BinarySearch(seq, n, value);
            BinarySearch A = new BinarySearch(seq, begin, n, value);

            Console.WriteLine(B.Search1());
            Console.WriteLine(B.Search2());
            Console.WriteLine(B.Search3());
            Console.WriteLine(A.SearchRecursive());
            Console.ReadKey();
        }
    }
}
