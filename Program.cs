using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorCsharpCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();
            OperationConverter operationConverter = new OperationConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            try {
                Console.WriteLine("- Simple Calculator Application -\n");
                Console.Write("Enter 1st number: ");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Enter operation: ");
                Operation operation = operationConverter.ConvertInputToOperation(Console.ReadLine());
                char operationSymbol = operationConverter.GetOperationSymbol(operation);

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                
                Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operationSymbol, secondNumber, result);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
