using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLINQ_Lamnda.Examples
{
    partial class PartialMethods//(1)
    {
        //declaration = ([modifier] dataType variable Name);
        //This version of will act as if the partial method doesn't exist.
        partial void MyWidgetStart(int count);//method definition
        partial void MywidgetEnd(int count);//method definition


        partial void MywidgetEnd(int count)//method definition
        {
            Console.WriteLine(count);//methods implementation
        }
        partial void MyWidgetStart(int count)//method definition
        {
            Console.WriteLine(count);//methods implementation
        }
        public PartialMethods()//class constructor
        {
            int count = 0;
            MyWidgetStart(++count);
            Console.WriteLine("Constructor");
            MywidgetEnd(++count);
        }//output: count = 0
        //========================================================//
        //Partial methods are methods where the definition of the method
        //is specified in the declration of the partial CLASSS(1) but
        //the implementation for the method is not provided in that same
        //declaration of the partial class. In fact there doesn't have to 
        //have any implementation anywhere, and the compiler will not
        //emit any IL code. Acting as it was never written.
        //========================================================//
   

        //===============
        //This is mainly for writing large programs in teams. Creating 
        //this partial method to easily call at a later time (IF YOU WANT)
        //if you don't want the compiler never wastes Any Memory on IL code.
        //===============
    }
}
