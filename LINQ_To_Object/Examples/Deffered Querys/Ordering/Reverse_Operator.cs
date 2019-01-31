using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_To_Object.Linq_To_Object_SQL_Database.Common;

namespace LINQ_To_Object.Examples.Deffered_Querys.Ordering
{
    class Reverse_Operator
    {
        Presidents_Array presidents = new Presidents_Array();
        
        public static void Reverse()
        {
            Presidents_Array presidents = new Presidents_Array();
            var reverse = presidents.presidents
                .Reverse();//Wow
        }
    }
}
