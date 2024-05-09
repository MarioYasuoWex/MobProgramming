using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Utility
    {
        public double EvaluateCalculation(string text)
        {
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
    }
}
