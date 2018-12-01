using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public class BinarySearch
    {
        private int[] seq;
        private int n;
        private int value;
        public BinarySearch(int[] s, int N, int v)
        {
            seq = s;
            n = N;
            value = v;
        }

        //First version
        public int Search()
        {
            int min = 0;
            int max = n - 1;

            while(min <= max)
            {
                int med = (min + max) / 2;
                if(seq[med] == value)
                {
                    return med;
                }
                if(seq[med] < value)
                {
                    min = med + 1;
                }
                else
                {
                    max = med - 1;
                }
            }
            return -1;
        }
    }
}
