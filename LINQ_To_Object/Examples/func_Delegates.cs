using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_To_Object.Examples
{
    class func_Delegates
    {
        public static void Function()
        {

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Func<int, bool> greaterThanTwo = i => i > 2;

            IEnumerable<int> greaterThanTwoList = ints.Where(greaterThanTwo);

            foreach(int i in greaterThanTwoList)
                Console.WriteLine(i);

            //==================================================================================
            //The Func delegate is a way to create generic functions that with the bool and other 
            //delegate will allow, i in this case to pass or not. the greaterthatwo func is a 
            //check to so if the input i is greater than 2. If it is, it allows the i to be passed
            //through the Ieumerable gtTwoList. But remember that the query is deferred so wont be 
            //passed until the foreach loop.
            //==================================================================================

            //=====================================Output=======================================
            //3
            //4
            //5
            //6
            //7
            //8
            //9
            //=====================================Output========================================
        }
    }
}
