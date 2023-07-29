namespace csharp32.Tests
{
    [TestClass]
    public class ArrayMethodTests
    {
        [TestMethod]
        public void CallingSwapElementsWithElement1AndElement2ReturnsSwappedPositions()
        {
            // arrange
            int element1 = 1;
            int element2 = 2;

            //act
            ArrayMethod.SwapElements(ref element1, ref element2);

            //assert
            Assert.AreEqual(2, element1);
            Assert.AreEqual(1, element2);
        }

        [TestMethod]
        public void CallingSwapElementsWithElement10AndElement20ReturnsSwappedPositions()
        {
            // Arrange
            int element1 = 10;
            int element2 = 20;

            // Act
            ArrayMethod.SwapElements(ref element1, ref element2);

            // Assert
            Assert.AreEqual(20, element1);
            Assert.AreEqual(10, element2);
        }
    }
}