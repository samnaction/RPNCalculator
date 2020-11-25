namespace RPNCalculatorLibTest
{
    using NUnit.Framework;
    using RPNCalculatorLib;

    public class RPNCalculatorTests
    {
        [Test]
        public void TestSimpleAddition()
        {
            // SetUp
            RPNCalculator rpnCalculator = new RPNCalculator();

            //Act
            double actualResult = rpnCalculator.add("10 15 +");
            double expectedResult = 25.0;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

            //Act
            actualResult = rpnCalculator.add("100 15 +");
            expectedResult = 115.0;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
