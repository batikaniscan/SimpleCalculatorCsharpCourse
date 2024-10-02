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

    public class OperationConverter
    {
        private Dictionary<string, Operation> operationDictionary;

        public OperationConverter() {
            operationDictionary = new Dictionary<string, Operation>();
            initializeDictionary();
        }

        private void initializeDictionary() {
            operationDictionary.Add("add", Operation.ADDITION);
            operationDictionary.Add("addition", Operation.ADDITION);
            operationDictionary.Add("+", Operation.ADDITION);

            operationDictionary.Add("substract", Operation.SUBSTRACTION);
            operationDictionary.Add("substraction", Operation.SUBSTRACTION);
            operationDictionary.Add("-", Operation.SUBSTRACTION);

            operationDictionary.Add("multiply", Operation.MULTIPLICATION);
            operationDictionary.Add("multiplication", Operation.MULTIPLICATION);
            operationDictionary.Add("x", Operation.MULTIPLICATION);
            operationDictionary.Add("*", Operation.MULTIPLICATION);

            operationDictionary.Add("divide", Operation.DIVISION);
            operationDictionary.Add("division", Operation.DIVISION);
            operationDictionary.Add("/", Operation.DIVISION);

            operationDictionary.Add("remainder", Operation.MODULUS);
            operationDictionary.Add("modulus", Operation.MODULUS);
            operationDictionary.Add("%", Operation.MODULUS);
        }

        public Operation ConvertInputToOperation(string argTextInput) {
            if (operationDictionary.TryGetValue(argTextInput.Trim().ToLower(), out Operation operation))
            {
                return operation;
            }
            else {
                throw new InvalidOperationException("This operation is not recognized.");
            }
        }

        public char GetOperationSymbol(Operation operation)
        {
            switch (operation)
            {
                case Operation.ADDITION:
                    return '+';
                case Operation.SUBSTRACTION:
                    return '-';
                case Operation.MULTIPLICATION:
                    return '*';
                case Operation.DIVISION:
                    return '/';
                case Operation.MODULUS:
                    return '%';
                default:
                    throw new InvalidOperationException("This operation is not recognized.");
            }
        }
    }
}
