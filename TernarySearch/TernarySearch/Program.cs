using System;

namespace TernarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = { 3, 7, 25, 26, 28, 30, 34, 42, 44, 50, 60, 62, 75, 86, 99, 125, 145, 209, 250 };
            int n = seq.Length;
            int v = 25;
            int begin = 0;
            TernarySearch T = new TernarySearch(seq, n, v);
            TernarySearch TR = new TernarySearch(seq, begin, n, v);
            Console.WriteLine(T.Search1());
            Console.WriteLine(T.Search2());
            Console.WriteLine(TR.SearchRec());
            Console.ReadKey();
        }
    }
}
