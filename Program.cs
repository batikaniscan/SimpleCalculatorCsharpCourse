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
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Operation operation = operationConverter.ConvertInputToOperation(Console.ReadLine());

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
