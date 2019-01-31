using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_To_Object.Linq_To_Object_SQL_Database.Common
{
    class IEnumeration_Interface : IEnumerable<Shared_Employee_Class>
    {
        public IEnumerable<Shared_Employee_Class> Employee_Info_ { get; }


        public IEnumerator<Shared_Employee_Class> GetEnumerator()
        {
            return Employee_Info_.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
