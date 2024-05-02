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
            string numberLeft = "";
            string numberRight = "";

            for(var i = 0; i < text.Length; i++)
            {
                if (int.TryParse(text[i].ToString(), out int _))
                {
                    numberLeft = numberLeft + text[i];
                }

                if (IsAnLowerOperation(text[i]))
                {
                    // handle it
                }

                if (IsAnHigherOperation(text[i]))
                {
                    // handle it
                }
            }
            
            throw new NotImplementedException();
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
