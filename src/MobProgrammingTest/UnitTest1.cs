using SimpleCalculator;
using System.Security.Cryptography;
using System.Text;

namespace MobProgrammingTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OperationParsing()
        {
            string number1 = "50";
            string number2 = "2";
            string operation = "/";

            var op = new OperationModel(number1, number2, operation);
        }

    }
}