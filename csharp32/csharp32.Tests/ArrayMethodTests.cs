namespace csharp32.Tests
{
    [TestClass]
    public class ArrayMethodTests
    {
        [TestMethod]
        public void CallingSwapElementsInArrayWithNullArrayReturnsSwappedElements0()
        {
            // Arrange
            int[] array = null;
            int element1 = 0;
            int element2 = 1;

            // Act
            int[] resultArray = ArrayMethod.SwapElementsInArray(array, element1, element2);

            // Assert
            Assert.IsNotNull(resultArray, "Masyvas negali buti null");
        }

        [TestMethod]
        public void CallingSwapElementsInArrayWithGivenArrayReturnsSwappedFirstAndSecondElements()
        {
            // Arrange
            int[] array = {10, 20, 30, 40};
            int element1 = 0;
            int element2 = 1;

            // Act
            int[] resultArray = ArrayMethod.SwapElementsInArray(array, element1, element2);

            // Assert 
            Assert.AreEqual(20, resultArray[0]);
            Assert.AreEqual(10, resultArray[1]);
        }

        [TestMethod]
        public void CallingSwapElementsInArrayWithGivenArrayReturnsSwappedFirstAndThirdElements()
        {
            // Arrange
            int[] array = {1, 2, 3, 4};
            int element1 = 0;
            int element3 = 2;

            // Act
            int[] resultArray = ArrayMethod.SwapElementsInArray(array, element1, element3);

            // Assert
            Assert.AreEqual(3, resultArray[0]);
            Assert.AreEqual(1, resultArray[1]);
        }
    }
}