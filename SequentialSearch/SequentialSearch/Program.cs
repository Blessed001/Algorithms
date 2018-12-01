using System;

namespace SequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Seq = { 1,2,3,4, 5, 6, 7, 8, 9 };
            int n = Seq.Length;
            SequentialSearch S = new SequentialSearch(Seq, n, 9);


            Console.WriteLine("Sequencial Search {0}",S.SeqSearch());
            Console.WriteLine("Optimized Sequencial Search {0}", S.OptimizedSeqSearch());
            Console.ReadKey();
        }
    }
}
