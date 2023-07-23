using csharp26_1;

namespace csharp26_1.Tests
{
    [TestClass]
    public class PrimeGeneratorTests
    {
        [TestMethod]
        public void CallingGeneratePrimesWith10n()
        {
            // Arrange
            int n = 10;
            List<int> expectedResult = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            // Act
            List<int> actualResult = PrimeGenerator.GeneratePrimes(n);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult); // ColletionAssert. padeda su List testu.
        }

        [TestMethod]
        public void CallingGeneratePrimesWith20n()
        {
            // Arrange
            int n = 20;
            List<int> expectedResult = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71 };

            // Act
            List<int> actualResult = PrimeGenerator.GeneratePrimes(n);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult); // ColletionAssert. padeda su List testu.
        }
    }
}
