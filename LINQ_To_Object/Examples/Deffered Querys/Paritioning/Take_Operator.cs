using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Paritioning
{
    //=============================================================================
    //Partitioning allows you to create an output sequence which is a subset of an
    //input sequence.
    //=============================================================================
    class Take_Operator
    {
        //===================================Take=====================================
        //The Take operator returns a specific number of elements from the input 
        //sequence , starting from the beginning of the sequence.
        //===================================Prototype================================
        //
        //          public static IEnumerable<T> Take<T>(
        //              this IEnumerable<T> source,
        //              int count);
        //             
        //===================================Sumary===================================
        //The take operator will specify and int number and return that many elements
        //from the input source. When enumerated will yield the first count number of 
        //the elements from the input sequence. When the number is higher than that of
        //the count for the sequence, it just returns every element.
        //
        //=============================================================================

        public static void TakeFive()
        {
            var TakeTheFirstFiveNames = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .Take(5)
                .Select(p => p.firstName);
                

            foreach(var name in TakeTheFirstFiveNames)
            {
                Console.WriteLine(name);//outout: first 5 names of the shared employee list.
            }
        }

        public static void TakeFirstFiveLeters()
        {
            var TakeFirstFiveLetters = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .Take(5)
                .SelectMany(s => s.firstName.ToArray());

            foreach(char ch in TakeFirstFiveLetters)
            {
                Console.WriteLine(ch);//output: first 5 letters of everyones ame in the employee list.
            }
            //===============================
            //takes the first 5 elements of  the sequece and then passes that object
            //enumeration to the select many. 
            //===============================
        }
    }
}
