using System;
using System.Collections.Generic;
using System.Text;

namespace TernarySearch
{
    public class TernarySearch
    {
        int[] seq;
        int N;
        int Value;
        public TernarySearch(int[] s, int n, int v)
        {
            seq = s;
            N = n;
            Value = v;
        }
        //First version 
        public int Search1()
        {
            int min = 0;
            int max = N - 1;
            int fpivot;
            int spivot;

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
    }
}
