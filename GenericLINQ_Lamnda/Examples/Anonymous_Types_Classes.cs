using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLINQ_Lamnda.Examples
{
    class Anonymous_Types_Classes
    {
        public class Desk
        {
            public string toolname;
            public int howmany;
            public bool doIown;
        }
        public static void Oldway()
        {
            Desk Oldways = new Desk();
            Oldways.toolname = "So slow";
            Oldways.howmany = 0;
            Oldways.doIown = false;
        }
        //This is object Initilization before Object Init. Excisted. This is also the old way to Instatiate Generic objects like lists.

        //New way of Object Initialization
        public static void BetterWay()
        {
            var BetterWayOfInstatiatingObjects = new
            {
                name = "Wow better",
                howmanydoiown = 0,
                doIOwn = true
            };
            //There is a better way to construct This but if you want to create a one time object do it like betterway
        }
        

       
    }
}
