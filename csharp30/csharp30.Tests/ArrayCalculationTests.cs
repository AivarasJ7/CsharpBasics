namespace csharp30.Tests
{
    [TestClass]
    public class ArrayCalculationTests
    {
        [TestMethod]
        public void CountTwoDimensionalArraySumWithNull2dArrayReturnsZero()
        {
            // arrange
            int[,] array = null;
            int expectedResult = 0;

            // act
            int actualResult = ArrayCalculation.CountTwoDimensionalArraySum(array);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CountTwoDimensionalArraySumWithGiven2dArrayReturns44()
        {
            // arrange
            int[,] array = new int[,]
            {
                { 1, 5, 6 },
                { 3, 5, 2 },
                { 5, 8, 9 }
            };

            int expectedResult = 44;
            
            // act
            int actualResult = ArrayCalculation.CountTwoDimensionalArraySum(array);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Count2dArraySumWithGiven2dArrayReturns28()
        {
            // arrange
            int[,] array = new int[,]
            {
                { 1, 2, 4 },
                { 3, 5, 2 },
                { 4, 2, 5 }
            };

            int expectedResult = 28;

            // act
            int actualResult = ArrayCalculation.CountTwoDimensionalArraySum(array);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}