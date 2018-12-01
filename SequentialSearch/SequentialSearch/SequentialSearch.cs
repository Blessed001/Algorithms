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
        public SequentialSearch(int [] S,int N, int V)
        {
            seq = S;
            n = N;
            value = V;
        }

        //Sequencial search
        public int SeqSearch()
        {
            for(int i = 0; i < n; i++)
            {
                if(seq[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
