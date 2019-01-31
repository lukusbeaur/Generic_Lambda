using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;
using LINQ_To_Object.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Ordering
{
    class ThenBy_Operator
    {
        //==================================ThenBy================================
        //This operator accepts an IorderedEnumerable Object, to be ordered based
        //the key Selector method.
        //===================================Prototype================================
        //
        //public static IOrderedEnumerable<T> ThenBy<T, K>(
        //this IOrderedEnumerable<T> source,
        //Func<T, K> keySelector)
        //where
        //K : IComparable<K>;
        //
        //===================================Sumary===================================
        //In this prototype of the ThenBy operator, an ordered input sequence of type
        //IOrderedEnumerable<T> is passed into the ThenBy operator along with a keySelector method
        //delegate. The keySelector method is passed an input element of type T and will return the field within
        //the element that is to be used as the key value, of type K, for the input element.Types T and K may be the
        //same or different types.The value returned by the keySelector method must implement the
        //IComparable interface. The ThenBy operator will order the input sequence in ascending order based on
        //those returned keys
        //=============================================================================
        public static void OrderByThenBy()
        {
            Presidents_Array presidents_Array = new Presidents_Array();

            IEnumerable<string> items = presidents_Array.presidents
                .OrderBy(s => s.Length)
                .ThenBy(s => s);
                
            foreach(string item in items)
                Console.WriteLine(item);
        }
        public static void ThenByVowelRatio()
        {
            Presidents_Array presidents = new Presidents_Array();
            Comparer_Vowel_ConstantRatio comparer_Vowel = new Comparer_Vowel_ConstantRatio();

            IEnumerable<string> namesByRatio = presidents.presidents
                .OrderBy(n => n.Length)
                .ThenBy((s => s), comparer_Vowel);

            foreach(string item in namesByRatio)
            {
                int vCount = 0;
                int cCount = 0;
                comparer_Vowel.GetVowlConstantCount(item, ref vCount, ref cCount);
                double dRatio = (double)vCount / (double)cCount;

                Console.WriteLine($"{item}  -  {vCount}  -  {cCount}");
            }
        }
    }
}
