using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorCsharpCourse
{

    public enum Operation { 
        ADDITION,
        SUBSTRACTION,
        MULTIPLICATION,
        DIVISION,
        MODULUS
    }

    internal class OperationConverter
    {
        public Operation ConvertInputToOperation(string argTextInput) {
            switch (argTextInput.Trim().ToLower()) {
                case "add":
                case "addition":
                case "+":
                    return Operation.ADDITION;
                case "substract":
                case "substraction":
                case "-":
                    return Operation.SUBSTRACTION;
                case "multiply":
                case "multiplication":
                case "x":
                case "*":
                    return Operation.MULTIPLICATION;
                case "divide":
                case "division":
                case "/":
                    return Operation.DIVISION;
                case "remainder":
                case "modulus":
                case "%":
                    return Operation.MODULUS;
                default:
                    throw new InvalidOperationException("This operation is not recognized."); 
            }
        }
    }
}
