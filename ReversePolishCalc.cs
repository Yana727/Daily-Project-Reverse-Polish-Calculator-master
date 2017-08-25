using System;
using System.Collections.Generic;
using System.Linq; 


namespace Daily_Project_Reverse_Polish_Calculator
{
    public class ReversePolishCalc
    {

        // The array of the input string split up
        private String[] tokens;

        // The stack
        private Stack<double> stack = new Stack<double>();

        public double Calculate(String input)
        {

            // 1. Use the String split method to split the string into tokens at the commas
            tokens = input.Split(',');

            // 3. write the algorithm
            foreach (var item in tokens)
            { 
                if (item == "+")
                {
                    var a = stack.Pop();
                    var b = stack.Pop();
                    var result = b + a;
                    var realResult = result;
                    stack.Push(realResult);
                } else 
                if (item == "-")
                {
                   var a = stack.Pop(); 
                   var b = stack.Pop(); 
                   var result = b - a; 
                   var realResult = result; 
                   stack.Push(realResult); 
                } else 
                if (item == "*")
                {
                   var a = stack.Pop(); 
                   var b = stack.Pop(); 
                   var result = b * a; 
                   var realResult = result; 
                   stack.Push(realResult); 
                } else 
                if (item == "/")
                {
                   var a = stack.Pop(); 
                   var b = stack.Pop(); 
                   var result = b / a; 
                   var realResult = result; 
                   stack.Push(realResult); 
                } 
                else 
                 {
                  stack.Push(Convert.ToDouble(item)); 
                }

            }

            // 4. return the result
            return stack.Pop();
        }

        private Stack<double> GetStack1()
        {
            return stack;
        }

        private Stack<double> GetStack()
        {
            return stack;
        }
    }
}
