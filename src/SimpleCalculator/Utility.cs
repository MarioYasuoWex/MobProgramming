using System.Linq;

namespace SimpleCalculator
{
    public class Utility
    {
        public double EvaluateCalculation(string text)
        {
            string numberLeft = "";
            string numberRight = "";

            for(var i = 0; i < text.Length; i++)
            {
                var itemToEval = text[i].ToString();

                if (int.TryParse(itemToEval, out int _))
                {
                    numberLeft = numberLeft + text[i];
                }

                if (IsAnLowerOperation(text[i].ToString()))
                {
                    // handle it
                }

                if (IsAnHigherOperation(text[i].ToString()))
                {
                    // handle it
                }
            }
            
            throw new NotImplementedException();
        }

        public static bool IsAnLowerOperation(string text)
        {
            switch(text)
            {
                case "+":
                case "-":
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsAnHigherOperation(string text)
        {
            switch (text)
            {
                case "*":
                case "/":
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsValidOperation(string op) => op.Any(x => x.ToString() == "+" || x.ToString() == "-" || x.ToString() == "/" || x.ToString() == "*" );
    }
}
