using NUnit.Framework;
using RPNCalculatorLib;

namespace RPNCalculatorLibTest
{
    public class RPNCalculatorTests
    {
        [Test]
        public void TestSimpleAddition()
        {
            RPNCalculator rpnCalculator = new RPNCalculator();

            double actualResult = rpnCalculator.add("10 15 +");
            double expectedResult = 25.0;

            Assert.AreEqual(expectedResult, actualResult);
            
        }
    }
}