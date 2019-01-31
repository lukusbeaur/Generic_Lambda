using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLINQ_Lamnda.Examples
{
    class ExpressionTrees_OrderBy_Where
    {
        public static void Function()
        {
            int[] Numbers = new int[] { 4, 2, 7, 3, 1, 5, 0, 7, 4, 7, 3 };

            //This will pull the entire array check if each number is less than 4 and then order it by how it came in.
            IEnumerable<int> NumbersLessThanFour = Numbers
                .Where(i => i < 4)
                .OrderBy(i => i);

            //This will pull only i from the array where i is less than 4. and then order it by how it came in.
            IQueryable<int> NumbersLessThanfourQ = Numbers
                .Where(i => i < 4)
                .OrderBy(i => i)
                .AsQueryable();

            //============These Two examples above will give you the same result but the way they do it is very different. =================
            //The IEnumerable is written to Accept a delegate. the INT delegate. and will use the IL (Intermediate Language) to process this 
            //when it is called. This one is not often feasable when using it to call a database or a any other large repository
            //This is because it first (i => i) which gets the ENTIRE database and then runs the function of (i < 4) on it, followed by the 
            //Oderby(i =>i) which just takes the i coming in and has the i coming out. BElow is the Enumerable class 
            //======This takes the operator and works it syncronously, or one query at a time. LINEAR========================================
            //
            //      public static IEnumerable<T> where<T>(
            //              this IEnumerable<T> source, 
            //              Func<T, bool> predicate);
            //
            //===============================================================================================================================
            //The second Example uses Iqueryable which is written to accept an expression of a delegate. This doesn't use IL when it runs this 
            //query. This one is designed for SQL servers OR large data repositorys. It's better because it takes the operator querys and turns
            //them into ONE query executing them in parallel. Why is this a better approach? Because it takes the Database and only fetches what
            //it needs. Meaning the .where(i => i < 4) is excecuted at the same time ONLY getting the integers that are less than 4, and not the
            //whole databse. THis one is going from Linq to the SQL API as where the other Ienum way goes to LINQ to Object api.
            //================this takes the operators and combinds it into one query and on;y pulling what meets the functions prediction=====
            //
            //      public static IQueryable<T> where<T>(
            //          this IQueryable<T> Source, 
            //          System.Linq.Expressions.Expression<Func<Int, Bool>> Predicate);
            //
            //==================================================================================================================================
        }
    }
}
