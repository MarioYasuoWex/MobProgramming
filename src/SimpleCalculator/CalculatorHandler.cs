using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorHandler
    {
        public void EvaluateCalculation(string equation)
        {
            string numberLeft = string.Empty;
            string numberRight = string.Empty;

            bool IsRightNumber = false;
            
            foreach(var str in equation)
            {
                string strToVerify = str.ToString();
                if (int.TryParse(strToVerify, out int _) && !IsRightNumber)
                {
                    numberLeft = strToVerify;
                }
                else
                {
                    numberRight = strToVerify;
                }

                if (Utility.IsValidOperation(strToVerify))
                {

                }
            }
        }
    }
}
