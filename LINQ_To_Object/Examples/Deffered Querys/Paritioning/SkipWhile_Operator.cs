using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Paritioning
{
    class SkipWhile_Operator
    {
        //==================================SkipWhile================================
        //The SkipWhile Operator is very similair to the skip as it does skip certain
        //input  elements from the sequence, but instead of the static int , its a 
        //delegate method only returning elements that are true;
        //===================================Prototype================================
        //
        //              public static IEnumerable<T> SkipWhile<T>(
        //                  this IEnumerable<T> source,
        //                  Func<T, bool> predicate);           
        //             
        //===================================Sumary===================================
        //the skipwhile operator accepts an iput sequence with a delegate method predicate
        //which returns a an object, when eumerated yeilds results only if the delegate
        //returns false. 
        //TLDR: skips all elements that returns true on the delegate method.
        //
        //=============================================================================

        //====================================Prototype================================
        //
        //          public static IEnumerable<T> SkipWhile<T>(
        //              this IEnumerable<T> source,
        //              Func<T, int, bool> predicate);     
        //                
        //=====================================Summary=================================
        //Same as the first but with a 0 based index
        //============================================================================

        public static void SkipAllNamesStartingWithJ()
        {
            var skips = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .SkipWhile(p => p.firstName.Contains("d"))
                .Select(p => p.firstName);

            foreach(var x in skips)
            {
                Console.WriteLine(x);
            }
        }

        public static void SkipUntilReachesThreeOr()
        {
            Presidents_Array presidents_Array = new Presidents_Array();
            IEnumerable<string> skips = Initial_Get_Employee_Array_List.shared_Employee_Classes
                    .SkipWhile((p, i) => p.firstName.Length < 10 && i < 3)
                    .Select(p => p.firstName);
            IEnumerable<string> test = presidents_Array.presidents
                .Where((c, i) => (i % 2) == 0);//odd index.

            foreach(var x in test)
            {
                Console.WriteLine(x);
            }
        }
    }
}
