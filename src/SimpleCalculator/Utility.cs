using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public static class Utility
    {
        public static double EvaluateCalculation(string text)
        {
            /*
                operation example = 1+1-1
                operations in the string: 1+1 and 2-1
                first operation is equal to 2
                second operation is equal to the first result - 1
             */

            if (text.Contains("-"))
            {
                var parts = text.Split("-");
                var firstPart = parts[0];
                var secondPart = parts[1];                
                double.TryParse(firstPart, out double firstNumber);                
                double.TryParse(secondPart, out double secondNumber);
                return firstNumber - secondNumber;
            }

            if (text.Contains("+"))
            {
                var parts = text.Split("+");
                var firstPart = parts[0];
                var secondPart = parts[1];
                double.TryParse(firstPart, out double firstNumber);
                double.TryParse(secondPart, out double secondNumber);
                return firstNumber + secondNumber;
            }

            if (text.Contains("*"))
            {
                var parts = text.Split("*");
                var firstPart = parts[0];
                var secondPart = parts[1];
                double.TryParse(firstPart, out double firstNumber);
                double.TryParse(secondPart, out double secondNumber);
                return firstNumber * secondNumber;
            }

            if (text.Contains("/"))
            {
                var parts = text.Split("/");
                var firstPart = parts[0];
                var secondPart = parts[1];
                double.TryParse(firstPart, out double firstNumber);
                double.TryParse(secondPart, out double secondNumber);
                return firstNumber / secondNumber;
            }

            return 0;
        }

        public static double EvaluateCalculationComplex(string text)
        {
            // string pattern = @"(\d+\.?\d*) \* (.*)";
            // text= 120+120/40*20
            //       0123456789 



            while (text.Contains("/") || text.Contains("*"))
            {
                int symbPositionOfDiv = text.IndexOf("/");
                int symbPositionOfMul = text.IndexOf('*');
                int currOper;
                if (symbPositionOfDiv<symbPositionOfMul)
                {
                    currOper = symbPositionOfDiv;
                }
                
            }




            return 0;
        }

        public static bool IsAnLowerOperation(char text)
        {
            switch(text)
            {
                case '+':
                case '-':
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsAnHigherOperation(char text)
        {
            switch (text)
            {
                case '*':
                case '/':
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsValidHigherOperation(char operation) => new List<string> { "*", "/" }.Any(x => x == operation.ToString());
        public static bool IsValidLowerOperation(char operation) => new List<string> { "+", "-"}.Any(x => x == operation.ToString());
    }
}
