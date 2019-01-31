using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Concatenation
{
    //=======================================================================================
    //Concatenation is operator that accepts multiple input sequences of the same data type
    //and concatenates them together
    //=======================================================================================
    class Concat_Operator
    {
        //===================================Concat================================
        //Operator that accepts two input sequences and has 1 concatenated output
        //sequence
        //===================================Prototype================================
        //
        //          public static IEnumerable<T> Concat<T>(
        //              this IEnumerable<T> first,
        //              IEnumerable<T> second); 
        //             
        //===================================Sumary===================================
        //In this operator it accepts 2 sequeces with the same T data type, out putting
        //1 sequence
        //=============================================================================


        public static void TakeFiveSkipFiveConcat()
        {
            var list = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .Take(2)
                .Concat(Initial_Get_Employee_Array_List.shared_Employee_Classes.Skip(4));

            foreach(var x in list)
            {
                Console.WriteLine(x.firstName);
            }
        }
    }
}
