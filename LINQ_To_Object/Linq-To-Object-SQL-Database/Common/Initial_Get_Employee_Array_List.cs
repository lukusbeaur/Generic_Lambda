using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_To_Object.Linq_To_Object_SQL_Database.Common
{
    class Initial_Get_Employee_Array_List : IEnumeration_Interface
    {
        public static IEnumerable<Shared_Employee_Class> shared_Employee_Classes => new List<Shared_Employee_Class>
        {
            new Shared_Employee_Class
            {
                id = 1, firstName = "Joe", lastName = "Rattz"
            },
            new Shared_Employee_Class
            {
                id = 2, firstName = "William", lastName = "Gates"
            },
            new Shared_Employee_Class
            {
                id = 3, firstName = "Anderes", lastName = "Hejlsberg"
            },
            new Shared_Employee_Class
            {
                id = 4, firstName = "David", lastName="Lightman"
            },
            new Shared_Employee_Class
            {
                id = 101, firstName= "Kevin", lastName="Flynn"
            }
        };
    }
}
