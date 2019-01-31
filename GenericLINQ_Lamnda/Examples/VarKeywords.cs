using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLINQ_Lamnda.Examples
{
    class VarKeywords
    {
        public static void Function()
        {
            var stringname = "The framework will make this variable a string";
            Console.WriteLine(stringname);
            //===============================================================
            //The Var keyword uses Anonymous types, object initializing. The 
            //Example above does the following -----------------------------
            //By stating the variable =" The framwork...." This is implicityl
            //inferring the variable type to be a string. If I were to restate 
            //the variable like :
            //  stringname = 1; 
            //This will throw the exception: Can not implicitly change a String to an Int
            //You must also initialize the variable : If you call var Error; 
            //it will not compile becaue it needs to be initialized.
            //=================================================================

            var objectinitializing = new { name = "This will save the object Name", age = 1 };
            //=================================================================
            //With the info known above you know that this is initalizing objectinitialzing 
            //as its own object array. In order to get the info you'd have to type the following
            //==================================================================
            Console.WriteLine($"Name:{objectinitializing.name}    Age:{objectinitializing.age}");
            //Output: Name: This will save the object Name      Age:1
           
        }
    }
}
