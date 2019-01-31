using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Join
{
    class Join_Operator
    {
        //====================================Join====================================
        //The join operator performs an inner equiijoin on 2 sequences, comparing the 
        //extracted keys from the elements.
        //===================================Prototype================================
        //
        //          public static IEnumerable<V> Join<T, U, K, V>(
        //              this IEnumerable<T> outer,
        //               IEnumerable<U> inner,
        //               Func<T, K> outerKeySelector,
        //              Func<U, K> innerKeySelector,
        //              Func<T, U, V> resultSelector);
        //             
        //===================================Sumary===================================
        //The first method is called outer. Since this is an extension method, the obj
        //we are calling this on will be considered the outer. The operator will return
        //an object when enumerated will first enumerate the inner sequence(U). This calls
        //the inner keyselector once for each element in the sequence. This stores the 
        //elements referenced with a specific key into a hash table. After the same thing
        // will occur for the outer sequence(T). for each matching inner and outer element
        //pair the resultSelector method (v) will be called.
        //=============================================================================
        public static void JoinEmployees()
        {
            var joinByIds = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .Join(
                EmployeeOptionEntry.GetEmployeeOptionEntries(), //Inner Sequence
                e => e.id,//outer KeySelector
                i => i.id,//Inner KeySelector
                (e, i) => new//Result Selector
                {
                    id = e.id,
                    name = string.Format($"{e.firstName} {e.lastName}"),
                    options = i.optionsCount
                });
        foreach(var item in joinByIds)
                Console.WriteLine(item);
           
        }
        
        
    }
}
