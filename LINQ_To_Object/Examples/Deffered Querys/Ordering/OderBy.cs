using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;
using LINQ_To_Object.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Ordering
{
    class OrderBy
    {
        //===================================OrderBy==================================
        //==unstable== This means that the elements are not preserved when this operator
        //is called. The order by operator accepts and input sequence, that returns a
        // key with each element and an ordered output sequence.
        //===================================Prototype================================
        //
        //                  public static IOrderedEnumerable<T> OrderBy<T, K>(
        //                      this IEnumerable<T> source,
        //                      Func<T, K> keySelector)
        //                          where
        //                       K : IComparable<K>;           
        //
        //===================================Sumary===================================
        //in this prototype an input source sequence is passed into the orderBy operator
        //along with a keySelector method delegate.This returns an object, upon enumerator
        //returns the input sequence and passes a key with each element, ordering the 
        //output by the key selector.
        //=============================================================================

        //====================================Prototype================================
        //              
        //                  public static IOrderedEnumerable<T> OrderBy<T, K>(
        //                      this IEnumerable<T> source,
        //                      Func<T, K> keySelector,
        //                      IComparer<K> comparer);
        //                               
        //=====================================Summary=================================
        //This is the same as the first one except is allows for a comparer object to
        //be passed.
        //============================================================================

        public static void OrderByNameLength()
        {
            Presidents_Array _Array = new Presidents_Array();

            var orderby = _Array.presidents
                .OrderBy(s => s.Length);

            foreach(var x in orderby)
            {
                Console.WriteLine(x);
            }
        }
        public static void ConsonentsVowelRatio()
        {
            Presidents_Array _Array = new Presidents_Array();
            Comparer_Vowel_ConstantRatio _ConstantRatio = new Comparer_Vowel_ConstantRatio();

            IEnumerable<string> namesByVToCRatio = _Array.presidents
                .OrderBy((s => s), _ConstantRatio);

            foreach(string item in namesByVToCRatio)
            {
                int vCount = 0;
                int cCount = 0;

                _ConstantRatio.GetVowlConstantCount(item, ref vCount, ref cCount);//gets number of vowels for two strings, and returns the ratio and the comparer number
                double dRatio = (double)vCount / (double)cCount;
                Console.WriteLine($"{item} -- {dRatio} -- {vCount} : {cCount}");
            }
            
        }
    }
}
