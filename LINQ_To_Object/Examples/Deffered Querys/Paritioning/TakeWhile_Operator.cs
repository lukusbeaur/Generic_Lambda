using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Paritioning
{
    class TakeWhile_Operator
    {
        //===================================TakeWhile================================
        //This operator yields a sequence as long as a certain condition is met, while
        //starting at the 0 index of the input sequence
        //===================================Prototype================================
        //
        //          public static IEnumerable<T> TakeWhile<T>(
        //              this IEnumerable<T> source,
        //              Func<T, bool> predicate); 
        //
        //===================================Sumary===================================
        //The TakeWhile Operato accepts a input sequence and a predicate delegate method
        //and returns an object, that when enumerated yields elements utill the predicate
        //delegate returns false.
        //TLDR: Its like the take method but the number is undefined. But returns elements
        //until the delegate method returns false, then returns no other elemens
        //=============================================================================

        //====================================Prototype================================
        //
        //              public static IEnumerable<T> TakeWhile<T>(
        //                  this IEnumerable<T> source,
        //                  Func<T, int, bool> predicate); 
        //                
        //=====================================Summary=================================
        //This is the same as the one above with the only exception being it has a max
        //int returned starting from the index of 0.
        //============================================================================

        public static void TakeWhileNameLengthLessThanFive()
        {
            var takeNames = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .TakeWhile(p => p.firstName.Length < 5)
                .Select(p => p.firstName);

            foreach(var name in takeNames)
            {
                Console.WriteLine(name);//Output: Joe. Because the next name is larger than 5 chars (William) and then stops the search.
            }
        }

        public static void TakeFirstThreeOrUntilFalse()
        {
            var namesOrFail = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .TakeWhile((p , i) => (p.firstName.Length > 1) && (i<4))
                .Select(p => p.firstName);

            foreach(var names in namesOrFail)
            {
                Console.WriteLine(names);//outout:  first 4 names because the first requiment never returns false
            }
        }
    }
}
