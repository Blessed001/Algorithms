using System;
using System.Collections.Generic;
using System.Text;

namespace SequentialSearch
{
    public class SequentialSearch
    {
        private int [] seq;
        private int n;
        private int value;
        private int i;
        public SequentialSearch(int [] S,int N, int V)
        {
            seq = S;
            n = N;
            value = V;
        }

        //Sequencial search
        public int SeqSearch()
        {
            for(i = 0; i < n; i++)
            {
                if(seq[i] == value)
                {
                    return seq[i];
                }
            }
            return -1;
        }

        //Optimized sequencial search
        public int OptimizedSeqSearch()
        {
            for(i = 0; i < n; i++)
            {
                if (seq[i] >= value) 
                break;
            }
            if(i < n && seq[i] == value)
            {
                return seq[i];
            }
            else
            {
                return -1;
            }
        }


    }
}
