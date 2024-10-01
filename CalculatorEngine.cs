using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorCsharpCourse
{
    internal class CalculatorEngine
    {
        public double Calculate(Operation operation, double firstNumber, double secondNumber) {
            switch (operation) {
                case Operation.ADDITION:
                    return firstNumber + secondNumber;
                case Operation.SUBSTRACTION:
                    return firstNumber - secondNumber;
                case Operation.MULTIPLICATION:
                    return firstNumber * secondNumber;
                case Operation.DIVISION:
                    return firstNumber / secondNumber;
                case Operation.MODULUS:
                    return (int)Math.Floor(firstNumber % secondNumber);
                default:
                    throw new InvalidOperationException("This operation is not recognized.");
            }
        }
    }
}
