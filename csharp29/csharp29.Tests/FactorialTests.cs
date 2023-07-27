namespace csharp29.Tests
{
    [TestClass]
    public class FactorialTests
    {
        // The factorial of 0 (written as 0!) is defined to be 1.
        // It might seem counterintuitive at first, but mathematically, 0! is considered to be equal to 1.
        // So, 0! = 1.
        [TestMethod]
        public void CalculateFactorialWith0Returns1()
        {
            // arrange
            int number = 0;
            int expectedResult = 1;

            // act
            int actualResult = Factorial.CalculateFactorial(number);

            // assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateFactorialWith1Returns1()
        {
            // arrange
            int number = 1;
            int expectedResult = 1;

            // act
            int actualResult = Factorial.CalculateFactorial(number);

            // assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateFactorialWith5Returns120()
        {
            // arrange
            int number = 5;
            int expectedResult = 120;

            // act
            int actualResult = Factorial.CalculateFactorial(number);

            // assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateFactorialWith4Returns24()
        {
            // arrange
            int number = 4;
            int expectedResult = 24;

            // act
            int actualResult = Factorial.CalculateFactorial(number);

            // assert

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}