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
            // text= 120+120/40*20-40
            // 1. 120+3*20  
            //       0123456789 


            //Multiplication and division operations
            while (text.Contains("/") || text.Contains("*"))
            {
                int symbPositionOfDiv = text.IndexOf("/") == -1 ? text.Length : text.IndexOf("/");
                int symbPositionOfMul = text.IndexOf("*") == -1 ? text.Length : text.IndexOf("*");
                int currOper;

                if (symbPositionOfDiv < symbPositionOfMul)
                {
                    currOper = symbPositionOfDiv;
                }
                else
                {
                    currOper = symbPositionOfMul;
                }

                int i = 1;
                string left = "";
                while (currOper - i >= 0 && int.TryParse(text[currOper - i].ToString(), out var _))
                {
                    left = text[currOper - i] + left;
                    i++;
                }
                int leftInd = currOper - i;



                int j = 1;
                string right = "";

                while (currOper + j < text.Length && int.TryParse(text[currOper + j].ToString(), out var _))
                {
                    right += text[currOper + j];
                    j++;
                }

                text = text.Substring(0, leftInd + 1) + EvaluateCalculation(left + text[currOper] + right) + text.Substring(currOper + j--);

            }

            //Next continue addition and subtraction ops
            // text= 120+60-40

            // KNOWN ISSUE: Calculations with negative numbers at the beginning will get an infinite loop
            while (text.Contains("+") || (text.Contains("-") && !double.TryParse(text, out _)))
            {
                int symbPositionOfAdd = text.IndexOf("+") == -1 ? text.Length : text.IndexOf("+");
                int symbPositionOfSub = text.IndexOf("-") == -1 ? text.Length : text.IndexOf("-");
                int currOper;

                if (symbPositionOfAdd < symbPositionOfSub)
                {
                    currOper = symbPositionOfAdd;
                }
                else
                {
                    currOper = symbPositionOfSub;
                }

                int i = 1;
                string left = "";
                while (currOper - i >= 0 && int.TryParse(text[currOper - i].ToString(), out var _))
                {
                    left = text[currOper - i] + left;
                    i++;
                }
                int leftInd = currOper - i;



                int j = 1;
                string right = "";

                while (currOper + j < text.Length && int.TryParse(text[currOper + j].ToString(), out var _))
                {
                    right += text[currOper + j];
                    j++;
                }

                text = text.Substring(0, leftInd + 1) + EvaluateCalculation(left + text[currOper] + right) + text.Substring(currOper + j--);
            }


            double.TryParse(text, out double result);
            return result;
        }

        public static bool IsAnLowerOperation(char text)
        {
            switch (text)
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
        public static bool IsValidLowerOperation(char operation) => new List<string> { "+", "-" }.Any(x => x == operation.ToString());
    }
}
