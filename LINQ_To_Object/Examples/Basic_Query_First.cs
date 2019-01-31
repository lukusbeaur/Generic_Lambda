using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_To_Object.Examples
{
    static class Basic_Query_First
    {

        public static void fucntion()
        {
            string[] presidents = {
                "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland",
                "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield",
                "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson",
                "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley",
                "Monroe", "Nixon", "Obama", "Pierce", "Polk", "Reagan", "Roosevelt",
                "Taft", "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"
            };

            string FirstPresident = presidents
                .Where(p => p.StartsWith("Lin"))
                .First();

            Console.WriteLine(FirstPresident);
            //This takes a legacy data set of C# and returns ONE string object from the array
            //by using "First();" we do nto need to use foreach, and because we instantiated the 
            //firstpresident variable and defined it as a string type
        }
    }
}
