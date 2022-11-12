using System;
using System.Collections.Generic;

namespace _12___EventsAndDelegates.Exercises
{
    internal class Exercise14
    {
        //* Subject:
        // Create a dictionary that will contain<string, Func<>> pairs.
        // The keys will be operation signs "+", "-", "/", "*" 
        // And values will be the lambda expressions that will perform the corresponding operation on two floats 
        // And return a result with type float.

        //* One more time in details:
        //- Create and store using static keyword Lambda expressions with names Plus, Minus, Divide and Multiply.
        //- You can store function as follow:
        //- static Func<int, int> Name = (a) => a;
        //- Create a static dictionary called Operators that uses a string as a Key and lambda function as a value.
        //- Example: { "sign", Function}
        //- Create a static method OperationGet that will get as input a string, test if this string is a Key in the dictionary 
        //- And if positive return function otherwise returns null.

        static Func<float, float, float> Plus = (a, b) => a + b;
        static Func<float, float, float> Minus = (a, b) => a - b;
        static Func<float, float, float> Divide = (a, b) => a / b;
        static Func<float, float, float> Multiply = (a, b) => a * b;

        static public Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>{
                {"+", Plus},
                {"-", Minus},
                {"/", Divide},
                {"*", Multiply}
            };

        public static Func<float, float, float> OperationGet(string s)
        {
            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            return null;
        }
    }
}
