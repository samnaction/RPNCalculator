namespace RPNCalculatorLibTest
{
    using NUnit.Framework;
    using RPNCalculatorLib;

    public class RPNCalculatorTests
    {
        private RPNCalculator rpnCalculator;
        [SetUp]
        public void Init()
        {
            rpnCalculator = new RPNCalculator();
        }

        [TearDown]
        public void CleanUp()
        {
            rpnCalculator = null;
        }

        [Test]
        public void TestSimpleAddition()
        {
            
            // Act
            double actualResult = rpnCalculator.compute("10 15 +");
            double expectedResult = 25.0;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

            // Act
            actualResult = rpnCalculator.compute("100 15 +");
            expectedResult = 115.0;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestSimpleSubtraction()
        {   
            // Act
            double actualResult = rpnCalculator.compute("100 15 -");
            double expectedResult = 85.0;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

            // Act
            actualResult = rpnCalculator.compute("100 10 -");
            expectedResult = 90.0;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestSimpleMultiplication()
        {
          
            // Act
            double actualResult = rpnCalculator.compute("100 15 *");
            double expectedResult = 1500.0;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

            // Act
            actualResult = rpnCalculator.compute("100 10 *");
            expectedResult = 1000.0;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestSimpleDivision()
        {
           
            // Act
            double actualResult = rpnCalculator.compute("100 10 /");
            double expectedResult = 10.0;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

            // Act
            actualResult = rpnCalculator.compute("1000 10 /");
            expectedResult = 100.0;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestComplexRpnExpression()
        {

            // Act
            double actualResult = rpnCalculator.compute("10 5 * 100 20 / -");
            double expectedResult = 45.0;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
