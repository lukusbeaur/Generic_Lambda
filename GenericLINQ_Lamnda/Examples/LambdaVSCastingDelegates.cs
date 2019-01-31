using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLINQ_Lamnda.Examples
{
    public  class LambdaVSCastingDelegates
    {
        public static void Function()
        {
            //uses common coding.int filtering
            //uses aplication codeing. isodd


            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //This array uses a predefined  anonymous Filter and passes that to the Generic delegate  in FilterArrayOfInts
            //This is used when you have to reuse the code a lot
            int[] Isodd = Common_Coding.IntFilter.FilterArrayOfInts(Numbers, Application_Code.Int_IsOdd.IsOdd);
            //This is passing a function in the calling that passes to the generic delegate in the filterArrayOfInts
            //This is used when you have to call it once
            int[] IsEven = Common_Coding.IntFilter.FilterArrayOfInts(Numbers, delegate (int i) { return (i % 2) == 0; });

            //This will use Linq and Lamnda to dictate and pass the delegate
            //Notice the Casting of the delegate is not in the Lambda version. Consider this (x => x) this is x in and x out. if the x was an int coming it, the casted
            //delegate would be an int coming out. 
            //Consider this (x => x.length > 7) this is an x in but a bool out. The delegate would be a bool type.
            int[] IsEvenLam = Common_Coding.IntFilter.FilterArrayOfInts(Numbers, i => ((i % 2) == 0));

            foreach (int x in Isodd)
            {
                Console.WriteLine(x);
            }
            foreach (int x in IsEven)
            {
                Console.WriteLine(x);
            }
            foreach (int x in IsEvenLam)
                Console.WriteLine(x);
        }
    }
}
