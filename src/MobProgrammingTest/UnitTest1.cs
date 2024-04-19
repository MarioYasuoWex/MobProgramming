using MobProgramming;
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
        public void Test1()
        {
            //Arrange
            var class1 = new Class1();
            //Act
            var result = class1.TestMethod();
            //Assert
            Assert.That(result, Is.EqualTo("Hello World!") );
        }

    }
}