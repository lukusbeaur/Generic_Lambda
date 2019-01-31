using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Restriction
{

    //========================================================
    //Restriction operators are used for including or excluding
    //elements of an input sequence.
    //========================================================

    class Where_Operator
    {
        //======================Where=========================
        //The Where Operator is used to filter elements into
        //Sequence
        //=======================Prototype====================
        //
        //      public static IEnumerable<T> Where<T>(
        //          this IEnumerable<T> source,
        //          Func<T, bool> predicate);
        //
        //========================Summary======================
        //This prototype of Where takes an input source sequence
        //and a predicate method delegate and returns an object
        //that when enumerated, enumerates through the input
        //source yielding elements for which the predicate method
        //delagate returns true. TLDR: Takes entire list, and if
        //it matches the T input returns true it will yeild the 
        //result into the Where's sequence.
        //======================================================

        //=======================Prototype====================
        //
        //      public static IEnumerable<T> Where<T>(
        //          this IEnumerable<T> source,
        //          Func<T, int, bool> predicate);
        //
        //========================Summary======================
        //This Prototype is indetical to the one above, except 
        //it specifies that your predicate method delegate recieves
        // an additional argument. This integer will be the index
        //TLDR: same as the one above but has an index.
        //======================================================

        public static void Where_WithNoIndex()
        {

            var StartsWithJ = Initial_Get_Employee_Array_List.shared_Employee_Classes
                    .Where(p => p.firstName.StartsWith("J"))
                    .Select(p => p.firstName);

            foreach(var x in StartsWithJ)
            {
                Console.WriteLine(x);//Outputs : Joe
            }

        }

        public static void Where_WithIndex()
        {
            //var OddNumberID = Initial_Get_Employee_Array_List.shared_Employee_Classes
            //  .Where(p => (p.id & 1) == 1)
            //.Select(p => p.firstName + p.id); This is wrong BUT its cool so I didn't delete it. Outputs Every First name with an Odd id followed by the id


            var OddNumberIndex = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .Where((p, i) => (i & 1) == 1)
                .Select(p => p.firstName);

            foreach(var x in OddNumberIndex)
            {
                Console.WriteLine(x);//Outputs : William /n/ David
            }

        }
    }
}
