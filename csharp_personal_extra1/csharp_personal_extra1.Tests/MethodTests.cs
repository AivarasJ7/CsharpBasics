namespace csharp_personal_extra1.Tests
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GetFizzBuzzWithNullArrayReturnsEmptyArray()
        {
            // Arrange
            int[] array = null;

            // Act
            string[] actualResults = Method.GetFizzBuzz(array);

            // Assert
            Assert.IsNotNull(actualResults);
            Assert.AreEqual(0, actualResults.Length);
        }

        [TestMethod]
        public void CallGetFizzBuzzWithGivenArrayNumbersReturnsIfNumberDividesFrom3FizzIfNumberDividesFrom5BuzzIFDividesFromBothFizzBuzz()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            string[] expectedResults = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            // Act
            string[] actualResults = Method.GetFizzBuzz(array);

            // Assert
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void GetFizzBuzzWithGivenArrayNumbersReturnsIfNumberDividesFrom3FizzIfNumberDividesFrom5BuzzIFDividesFromBothFizzBuzz()
        {
            // Arrange
            int[] array = { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            string[] expectedResults = { "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "28", "29", "FizzBuzz" };

            // Act
            string[] actualResults = Method.GetFizzBuzz(array);

            // Assert
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }
    }
}