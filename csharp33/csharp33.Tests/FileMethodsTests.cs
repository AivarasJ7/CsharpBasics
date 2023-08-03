namespace csharp33.Tests
{
    [TestClass]
    public class FileMethodsTests
    {
        [TestMethod]
        public void ConvertToNumberListReturnsListFromFileInInt()
        {
            // Arrange
            List<string> lines = new List<string>
            {
                "4",
                "5",
                "7",
                "2",
                "10",
                "18",
                "17"
            };

            List<int> expectedResult = new List<int> { 4, 5, 7, 2, 10, 18, 17 };

            // Act
            List<int> actualResult = FileMethods.ConvertToNumberList(lines);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FindMaxNumberFromFileReturns18()
        {
            // Arrange
            List<int> numbers = new List<int> { 4, 5, 7, 2, 10, 18, 17 };
            int expectedResult = 18;

            // Act
            int actualResult = FileMethods.FindMaxNumberFromFile(numbers);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FindMinNumberFromFileReturns2()
        {
            // Arrange
            List<int> numbers = new List<int> { 4, 5, 7, 2, 10, 18, 17 };
            int expectedResult = 2;

            // Act
            int actualResult = FileMethods.FindMinNumberFromFile(numbers);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateAverageFromFileReturnsAverage9Point428() // Nežinau kaip kableli arba taška iterpti :D :(
        {
            // Arrange
            List<int> numbers = new List<int> { 4, 5, 7, 2, 10, 18, 17 };
            double expectedResult = 9.428571428571429;

            // Act
            double actualResult = FileMethods.CalculateAverageFromFile(numbers);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetRandomNumberFromFile_ReturnsRandomNumber()
        {
            // Arrange
            List<int> numbers = new List<int> { 4, 5, 7, 2, 10, 18, 17 };

            // Act
            int randomNumber = FileMethods.GetRandomNumberFromFile(numbers);

            // Assert
            Assert.IsTrue(numbers.Contains(randomNumber));
        }
    }
}
