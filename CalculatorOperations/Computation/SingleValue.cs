﻿using CalculatorOperations.Operations;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Computation
{
    /// <summary>
    /// A class that handles the calculation of single values
    /// </summary>
    public class SingleValue : ISingleValueCompute
    {
        private ISingleValueOperation _operation;

        public SingleValue()
        {
        }

        /// <summary>
        /// A method that calculates all single imputed value based on the type of operation
        /// </summary>
        /// <param name="value">The imputed value</param>
        /// <param name="type">The Operation type</param>
        /// <returns></returns>
        public decimal ComputeIt(decimal value, OperationType type)
        {
            decimal valueToReturn;
            switch (type)
            {
                case OperationType.Sine:
                    _operation = new Sine();
                    valueToReturn = _operation.Execute(value);
                    break;

                case OperationType.Cosine:
                    _operation = new Cosine();
                    valueToReturn = _operation.Execute(value);
                    break;

                case OperationType.Tangent:
                    _operation = new Tangent();
                    valueToReturn = _operation.Execute(value);
                    break;

                case OperationType.SquareRoot:
                    _operation = new SquareRoot();
                    valueToReturn = _operation.Execute(value);
                    break;

                case OperationType.Inverse:
                    _operation = new Inverse();
                    valueToReturn = _operation.Execute(value);
                    break;

                default:
                    valueToReturn = 0;
                    break;
            }

            return valueToReturn;
        }
    }
}