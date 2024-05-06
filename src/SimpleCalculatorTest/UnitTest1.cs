using SimpleCalculator;

namespace SimpleCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("50", "2", "/")]
        [TestCase("150", "15", "-")]
        [TestCase("221", "4", "*")]
        [TestCase("20341", "123", "+")]
        public void TestOperationModelParsing(string number1, string number2, string operation)
        {
            var op = new OperationModel(number1, number2, operation);

            Assert.That(op.NumberLeft, Is.EqualTo(double.Parse(number1)));
            Assert.That(op.NumberRight, Is.EqualTo(double.Parse(number2)));
        }

        [TestCase(50, 2, "/", 25)]
        [TestCase(150, 15, "-", 135)]
        [TestCase(221, 4, "*", 884)]
        [TestCase(20341, 123, "+", 20464)]
        public void TestOperationModelCalculation(double number1, double number2, string operation, double expectedResult)
        {
            var op = new OperationModel(number1, number2, operation);
            var modelResult = op.PerformOperation();

            Assert.That(modelResult, Is.EqualTo(expectedResult));
        }

        [TestCase(50, 2, "/")]
        [TestCase(150, 15, "-")]
        [TestCase(221, 4, "*")]
        [TestCase(20341, 123, "+")]
        public void TestOperationModelConstruction(double number1, double number2, string operation)
        {
            var op = new OperationModel(number1, number2, operation);
            var modelResult = op.GetOperationAsString();

            Assert.That(modelResult, Is.EqualTo($"{number1}{operation}{number2}"));
        }
    }
}