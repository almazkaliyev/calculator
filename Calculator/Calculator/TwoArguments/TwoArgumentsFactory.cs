﻿using System;

namespace Calculator.TwoArguments
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculatorByButtonName(string calculatorName)
        {
            switch (calculatorName)
            {
                case "ButtonAddition":
                    return new AdditionCalculator();
                case "ButtonSubstraction":
                    return new SubstractionCalculator();
                case "ButtonMultiplication":
                    return new MultiplyCalculator();
                case "ButtonDivision":
                    return new DivisionCalculator();
                default:
                    throw new Exception("Unknown calculator name");
            }
        }
    }
}