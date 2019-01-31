using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Projection
{
    //==========================================================================
    //The Projections type operators select certain elements from a sequence. The
    //Input data type does not have to be the same output data. 
    //==========================================================================
    class Select_Operator
    {
        //==================================Select====================================
        //The select operator is used to create an output sequence of one type from a 
        //different type of input sequences.
        //===================================Prototype================================
        //
        //          public static IEnumerable<S> Select<T, S>(
        //              this IEnumerable<T> source,
        //              Func<T, S> selector);
        //
        //===================================Sumary===================================
        //This prototype of Select takes an input source sequence and a selector method
        //delegate as the INPUT arguments, and it returns an object that when enumerated
        //, enumerates the input source sequence yeiling a sequence of elements of type S
        //. the T and S can be different or the same types as mention in the description.
        //TLDR : Input T is enumerated and a selector method in the Func delegate, has an
        //output of S. 
        //=============================================================================

        //====================================Prototype================================
        //
        //              public static IEnumerable<S> Select<T, S>(
        //                  this IEnumerable<T> source,
        //                  Func<T, int, S> selector)
        //
        //=====================================Summary=================================
        //This is the same as the previous one but has an Int I in the delegate for the 
        //index while enumerating.
        //============================================================================
        
        public static void NameLength()//No int I prototype
        {
            var LengthOfName = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .Select(p => p.firstName.Length);

            foreach (var x in LengthOfName)
            {
                Console.WriteLine(x); // Output 3 3 7 5 5 
            }
        }
        public static void NameAndLengthObject()// No Int I prototype
        {
            var NameObject = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .Select(p => new
                {
                    p.firstName,
                    p.firstName.Length
                });
            foreach(var item in NameObject)
            {
                Console.WriteLine(item);//Output : { firstName = Joe, Length = 3} .. Enumerates through entire list.
            }
        }

        public static void IndexAndNameOf()//Indexed 
        {
            var NameObject = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .Select((p, i) => new
                {
                    Index = i, LastName = p.lastName
                });

            foreach (var item in NameObject)
            {
                Console.WriteLine($"{item.Index + 1}.   {item.LastName}"); //Output: 1.  Rattz
            }
        }
        
    }
}
