namespace csharp27.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalllingEvenNumbersSumFromListReturns30()
        {
            //arrange
            List<int> numbers = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
            };

            int expectedResult = 30;

            //act

            int actualResult = Calculator.EvenNumbersSumFromList(numbers);

            //assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalllingEvenNumbersSumFromListReturns172()
        {
            //arrange
            List<int> numbers = new List<int>()
            {
                34,
                17,
                89,
                56,
                72,
                10,
            };

            int expectedResult = 172;

            //act

            int actualResult = Calculator.EvenNumbersSumFromList(numbers);

            //assert

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}