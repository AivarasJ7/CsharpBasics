namespace calculations.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CallingSumListNumbersWithProvidedListReturns10()
        {
            //arrange
            List<int> numbers = new List<int>()
            {
                5,
                3,
                2
            };

            int expectedResult = 10;
            //act

            int actualResult = Calculator.SumListNumbers(numbers);

            //assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingSumListNumbersWithProvidedListReturns15()
        {
            //arrange
            List<int> numbers = new List<int>()
            {
                5,
                5,
                2,
                3
            };

            int expectedResult = 15;
            //act

            int actualResult = Calculator.SumListNumbers(numbers);

            //assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingSumListNumbersWithNullListReturns0()
        {
            // arrange
            List<int> numbers = null;

            int expectedResult = 0;

            //act
            int actualResult = Calculator.SumListNumbers(numbers);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingSumListNumbersWithEmptyListReturns0()
        {
            //arrange
            List<int> numbers = new List<int>();

            int expectedResult = 0;

            //act
            int actualResult = Calculator.SumListNumbers(numbers);

            //assert
            Assert.AreEqual (expectedResult, actualResult);
        }
    }
}