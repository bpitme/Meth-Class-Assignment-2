using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathMethod2 class
            MathMethod2 math1 = new MathMethod2();
            //Call the first method with an int parameter
            Console.WriteLine(math1.MathOp(10));
            //call the Second method with a decimal parameter
            Console.WriteLine(math1.MathOp(10.3m));
            //call the third method with a string parameter
            Console.WriteLine(math1.MathOp("10"));
            Console.ReadLine();
        }
    }
}
