using SimpleCalculator;

namespace MobProgrammingTest
{
    public class Tests
    {
        [TestCase("1+1", ExpectedResult = 2)]
        [TestCase("6/2", ExpectedResult = 3)]
        [TestCase("5*10", ExpectedResult = 50)]
        [TestCase("1-1", ExpectedResult = 0)]
        [TestCase("1+2-1", ExpectedResult = 2)]
        public double EvaluateCalculationTest(string calculation)
        {
            var result = Utility.EvaluateCalculation(calculation);

            return result;
        } 
    }
}