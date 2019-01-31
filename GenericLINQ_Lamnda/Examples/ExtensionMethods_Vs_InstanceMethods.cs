using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLINQ_Lamnda.Examples
{
    static class ExtensionMethods_Vs_InstanceMethods
    {
        //==========Extension Method================//
        public static bool toBool(this string s)
        {
            return Boolean.Parse(s);
        }
        //===============================================//
        //
        //The reason why this is an extension method is 
        //because firstly its static, but secondly the 
        //first argument of this is of type string.
        //this means that it can only be an extension of 
        //a string method. In order to use this extension 
        //method you must specify "Using Examples.GenericLINQ_
        //Lambda.ExcensionMethods_Vs_InstanseMethods. The
        //Same way you would call System.Linq, which is also
        //a static method.
        //
        //==================================================//
    }
}
