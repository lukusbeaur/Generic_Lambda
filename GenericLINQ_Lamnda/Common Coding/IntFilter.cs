using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLINQ_Lamnda.Common_Coding
{
    class IntFilter
    {
        public delegate bool IntFilters(int i);

        public static int[] FilterArrayOfInts(int[]ints , IntFilters filters)
        {
            List<int> IntList = new List<int>();

            foreach(int i in ints)
            {
                if (filters(i))
                {
                    IntList.Add(i);
                }
            }
            return ((int[])IntList.ToArray());
        }
    }
}
