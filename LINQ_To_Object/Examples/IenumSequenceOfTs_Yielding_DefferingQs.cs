using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_To_Object.Examples
{
    class IenumSequenceOfTs_Yielding_DefferingQs
    {
        public static void Functions()
        {
            string[] presidents = {
            "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland",
            "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield",
            "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson",
            "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley",
            "Monroe", "Nixon", "Obama", "Pierce", "Polk", "Reagan", "Roosevelt",
            "Taft", "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"
            };

            IEnumerable<string> items = presidents
                                        .Where(p => (p.StartsWith("A")));

            //==========================================================================================
            //The Query above returns an Ienumerable Object with the delegate <string> but this does not 
            //enumerate the array.
            //==========================================================================================

            foreach(string item in items)
                Console.WriteLine(item);
            //=========================================================================================
            //The foreach loop enumerates through the Enumerable object returned by the Query,and this 
            // is where the .Where Extension actualy gets excecuted.
            //=========================================================================================

            IEnumerable<string> error = presidents
                                        .Where(s => char.IsLower(s[4]));

            Console.WriteLine("This is after the Query");

            foreach (string errors in error)
                Console.WriteLine(error);

            //===================================Exception============================================
            //This example will demonstrate that a query will compile, and run smoothly until it hits a
            //specific error. In this case when it enumerates to "Bush" the [4] index will not be present
            //but the output will be as follows.
            //Output:
            //This is after the Query
            //Auther
            //Adams
            //Exception thown. Index out of bounds. 
            //====================================Exception=============================================
            //====================================Summary===============================================
            //The Query => .Where gets excecuted in the FOREACH loop or when its one object in the cw().
            //in other words the query is defered, and the errors list holds the address of where to find
            //the enumerated object. To make this not deferred you'd ad the .ToList extension method. or
            //.ToArray, or ToDictionary. 
            //====================================Summary===============================================


        }
    }
}
