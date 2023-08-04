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
        public void ConvertToNumberListWithNullReturnsEmptyList()
        {
            // Arrange
            List<string> lines = null;

            // Act
            List<int> result = FileMethods.ConvertToNumberList(lines);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
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
        public void FindMaxNumberFromFileReturns20()
        {
            // Arrange
            List<int> numbers = new List<int> { 4, 5, 7, 2, 10, 20, 17 };
            int expectedResult = 20;

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
        public void FindMinNumberFromFileReturns1()
        {
            // Arrange
            List<int> numbers = new List<int> { 4, 5, 7, 1, 10, 18, 17 };
            int expectedResult = 1;

            // Act
            int actualResult = FileMethods.FindMinNumberFromFile(numbers);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateAverageFromFileReturnsAverage9()
        {
            // Arrange
            List<int> numbers = new List<int> { 4, 5, 7, 2, 10, 18, 17 };
            double expectedResult = 9;

            // Act
            double actualResult = FileMethods.CalculateAverageFromFile(numbers);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateAverageFromFileReturnsAverage8_571428571428571() // Nežinau kaip kableli arba taška iterpti :D :(
        {
            // Arrange
            List<int> numbers = new List<int> { 2, 5, 7, 1, 10, 18, 17 };
            double expectedResult = 8.571428571428571;

            // Act
            double actualResult = FileMethods.CalculateAverageFromFile(numbers);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetRandomNumberFromFileReturnsRandomNumber()
        {
            // Arrange
            List<int> numbers = new List<int> { 4, 5, 7, 2, 10, 18, 17 };

            // Act
            int randomNumber = FileMethods.GetRandomNumberFromFile(numbers);

            // Assert
            Assert.IsTrue(numbers.Contains(randomNumber));
        }

        [TestMethod]
        public void GetRandomNumberFromFileReturnsOtherRandomNumber()
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
