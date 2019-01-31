using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLINQ_Lamnda.Application_Code
{
    class Int_IsOdd
    {
        public static bool IsOdd(int i)
        {
            return ((i & 1) == 1);
        }
    }
}
