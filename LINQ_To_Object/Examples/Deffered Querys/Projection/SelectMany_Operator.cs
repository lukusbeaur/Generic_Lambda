using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Projection
{
    class SelectMany_Operator
    {
        //==================================SelectMany================================
        //Similair in the way Select handles sequences, selectmany selector will return
        //from 0 or more output elements for every input sequence
        //===================================Prototype================================
        //
        //          public static IEnumerable<S> SelectMany<T, S>(
        //              this IEnumerable<T> source,
        //              Func<T, IEnumerable<S>> selector);
        //             
        //===================================Sumary===================================
        //This prototype of the operaor is passed an input source sequence of type T and
        //a selector method delegate. Returning an object that when enumerated, enumerates
        //the input SOURCE, passing each element individually from the input sequence to
        //the selector method. The selector method then returns an object that when enumerated
        //yields zero or more of Type S.
        //=============================================================================

        //====================================Prototype================================
        //
        //              public static IEnumerable<S> SelectMany<T, S>(
        //                  this IEnumerable<T> source,
        //                  Func<T, int, IEnumerable<S>> selector);
        //                
        //=====================================Summary=================================
        //Works the same as the previous prototype, but has a base 0 Index input sequence.
        //============================================================================
        public static void LettersOfNameToArray()
        {
            IEnumerable<char> charofnames = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .SelectMany(p => p.firstName).ToArray();

            foreach(char ch in charofnames)
            {
                Console.WriteLine(ch);//output : J o e . . . .
            }
            //This is an example that works, but its pointless nonetheless
        }

        public static void EmployeeOptions()
        {
            EmployeeOptionEntry[] EmpOptions = EmployeeOptionEntry.GetEmployeeOptionEntries();
            var Employees = Initial_Get_Employee_Array_List.shared_Employee_Classes;

            var employeeOptions = Employees
                                    .SelectMany(e => EmpOptions
                                        .Where(eo => eo.id == e.id)
                                        .Select(eo => new
                                        {
                                            Id = eo.id, 
                                            OptionsCount = eo.optionsCount
                                        }));

            foreach(var items in employeeOptions)
            {
                Console.WriteLine(items);//OutPut:  { id = 1, optionsCount = 2 } ... id = 101
            }
            //======================================Sumary====================================
            //This looks like a lot but lets step through it. In the example every employee in the 
            //Employee list is passed into he lambda expression which is then passed into the 
            //selectmany Operator. The lambda expression will then get every entry of employee
            //optionEntry elements whos ID matches the ID of the current employee passed into it
            //After that the lambda creates a new anonymous object for each matching ID
            //TLDR: Takes every matching id from the two arrays and adds them into their own object.
            //================================================================================
        }
        public static void FirstFiveChars()
        {
            IEnumerable<char> FirstFiveChars = Initial_Get_Employee_Array_List.shared_Employee_Classes
                .SelectMany((p, i) => i < 5 ? p.firstName.ToArray() : new char[] { });
                    //i < int ?(if) == p to array :(else) casting as char[]
            foreach (char ch in FirstFiveChars)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
