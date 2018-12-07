using System;
using System.Collections.Generic;
using System.Text;

namespace TernarySearch
{
    public class TernarySearch
    {
        private int[] seq;
        private int N;
        private int Value;
        private int fpivot;
        private int spivot;
        private int begin;
        public TernarySearch(int[] s, int n, int v)
        {
            seq = s;
            N = n;
            Value = v;
        }
        public TernarySearch(int[] s, int b, int n, int v)
        {
            seq = s;
            begin = b;
            N = n;
            Value = v;
        }
        //First version 
        public int Search1()
        {
            int min = 0;
            int max = N - 1;

            while (min <= max)
            {
                int nelem = max - min + 1;
                if(nelem % 3 == 0)
                {
                    fpivot = min + (nelem / 3) - 1;
                    spivot = min + (2 * nelem / 3) - 1;
                }
                else
                {
                    fpivot = min + (nelem / 3);
                    spivot = min + (2 * nelem / 3);
                }
                if(seq[fpivot] == Value)
                {
                    return seq[fpivot];
                }
                else if(seq[fpivot] > Value)
                {
                    max = fpivot - 1;
                }
                else if(seq[spivot] == Value)
                {
                    return seq[spivot];
                }
                else if(seq[spivot]> Value)
                {
                    min = fpivot + 1; max = spivot - 1;
                }
                else
                {
                    min = spivot + 1;
                }
            }
            return -1;
        }
        // Secand version 
        public int Search2()
        {
            int min = 0;
            int max = N - 1;
            

            while (min < max)
            {
                int nelem = max - min + 1;
                fpivot = min + (nelem / 3);
                spivot = min + (2 * nelem / 3);

                if (seq[fpivot] > Value)
                {
                    max = fpivot-1;
                }
                else if (seq[spivot] > Value)
                {
                    min = fpivot; max = spivot - 1;
                }
                else
                {
                    min = spivot;
                }
            }
            if (seq[min] == Value)
            {
                return seq[min];
            }
            else
            {
                return -1;
            }
        }
        //Version recursive
        public int SearchRec()
        {
            if(begin > N)
            {
                return -1;
            }
            int nelem = N - begin + 1;
            if(nelem % 3 == 0)
            {
                fpivot = begin + (nelem / 3) - 1;
                spivot = begin + (2 * nelem / 3) - 1;
            }
            else
            {
                fpivot = begin + (nelem / 3);
                spivot = begin + (2 * nelem / 3);
            }

            if(seq[fpivot] == Value)
            {
                return seq[fpivot];
            }
            else if (seq[fpivot] > Value)
            {
                N = fpivot - 1;
            }
            else if(seq[spivot] == Value)
            {
                return seq[spivot];
            }
            else if(seq[spivot] > Value)
            {
                begin = fpivot + 1; N = spivot - 1;
            }
            else
            {
                begin = spivot + 1;
            }

            TernarySearch T = new TernarySearch(seq, begin, N, Value);
            return T.SearchRec();

        }        
    }
}
