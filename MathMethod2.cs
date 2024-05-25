using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_2
{
    internal class MathMethod2
    {
        //First method takes an integer
        public int MathOp(int number)
        {
            return number + 10;
        }
        // Second method takes a decimal
        public int MathOp(decimal number)
        {
            //convert the decimal to an int to perform math opration
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }
        //Third MathOp method that takes a string 
        public int MathOp(string number)
        {
            //convert the string to an int to perform math opration
            int newmum = Convert.ToInt32(number);
            return newmum % 8;
        }
    }
}
        

