namespace csharp31.Tests
{
    [TestClass]
    public class ArrayCalculationTests
    {
        [TestMethod]
        public void FindArrayMaxMinWithNullArrayReturnsArgumentException()
        {
            // Arrange
            int[] array = null;
            int actualMax, actualMin;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => ArrayCalculations.FindArrayMaxMin(array, out actualMax, out actualMin), "Masyvas negali buti 'null' ");
        }

        [TestMethod]
        public void FindArrayMaxMinWithGivenArrayReturns10MaxAnd2Min()
        {
            // arrange
            int[] array = { 6, 5, 7, 2, 10, 3 };
            int expectedMax = 10;
            int expectedMin = 2;

            // act
            ArrayCalculations.FindArrayMaxMin(array, out int actualMax, out int actualMin);

            // assert
            Assert.AreEqual(expectedMax, actualMax);
            Assert.AreEqual(expectedMin, actualMin);
        }

        [TestMethod]
        public void FindArrayMaxMinWithGivenArrayReturns20MaxAnd7Min()
        {
            // arrange
            int[] array = { 8, 9, 7, 20, 10, 13 };
            int expectedMax = 20;
            int expectedMin = 7;

            // act
            ArrayCalculations.FindArrayMaxMin(array, out int actualMax, out int actualMin);

            // assert
            Assert.AreEqual(expectedMax, actualMax);
            Assert.AreEqual(expectedMin, actualMin);
        }
    }
}