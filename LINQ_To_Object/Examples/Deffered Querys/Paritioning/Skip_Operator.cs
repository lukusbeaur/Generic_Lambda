using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Paritioning
{
    class Skip_Operator
    {
        //===================================Skip=====================================
        //The skip operator skips  a number of input elements from the sequece, and 
        //yields the rest.
        //===================================Prototype================================
        //
        //        public static IEnumerable<T> Skip<T>(
        //          this IEnumerable<T> source,
        //          int count);
        //             
        //===================================Sumary===================================
        //The skip operator is passed an input sequence which skips a number of elements
        //, which is labled "Int count". This returns an object that when enumerated, 
        //returns every element, except the initial count was skipped.
        //=============================================================================

       public static void SkipANumbedIndex()
        {
            var skipANumber = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .Skip(1)
                .Select(p => new
                {
                    Name = p.firstName,
                    LastName = p.lastName

                });

            foreach(var name in skipANumber)
            {
                Console.WriteLine(name);
            }
        }
    }
}
