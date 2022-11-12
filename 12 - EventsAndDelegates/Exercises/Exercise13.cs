using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _12___EventsAndDelegates.Exercises.Exercise13;

namespace _12___EventsAndDelegates.Exercises
{
    internal class Exercise13
    {
        //* Subject:
        //- Create a public delegate that will be called OperationDelegate and will get two arguments with float type and return float as well;
        //- Create 4 static public methods called Add, Subtract, Multiply, and Divide.
        //- All of them should get 2 arguments and return a float that corresponds to the result of the performed operation;
        //- Create ApplyOperation method that gets 2 floats and one delegate and applies the operation to those values;
        public delegate float OperationDelegate(float a, float b);

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            return a / b;
        }

        public static float ApplyOperation(float a, float b, OperationDelegate oper)
        {
            float result;

            result = oper(a, b);

            return result;
        }
    }
}
