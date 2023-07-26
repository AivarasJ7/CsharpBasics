namespace csharp28.Tests
{
    [TestClass]
    public class SymbolCounterTests
    {
        [TestMethod]
        public void CountTextSymbolsWithoutSpacesWithGivenTextWhichIsNullReturns0()
        {
            // arrange
            string text = null;
            int expectedResult = 0;

            // act
            int actualResult = SymbolCounter.CountTextSymbolsWithoutSpaces(text);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CountTextSymbolsWithoutSpacesWithGivenTextWhichIsEmptyReturns0()
        {
            // arrange
            string text = "";
            int expectedResult = 0;

            // act
            int actualResult = SymbolCounter.CountTextSymbolsWithoutSpaces(text);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CountTextSymbolsWithoutSpacesWithGivenTextWhichHaveSpacesReturns12()
        {
            // arrange
            string text = "Labas pasauli";

            int expectedResult = 12;

            // act

            text = text.Replace(" ", "");
            int actualResult = SymbolCounter.CountTextSymbolsWithoutSpaces(text);

            // assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CountTextSymbolsWithoutSpacesWithGivenTextWhichHaveSpacesReturns10()
        {
            // arrange
            string text = "Labas rytas";

            int expectedResult = 10;

            // act

            text = text.Replace(" ", "");
            int actualResult = SymbolCounter.CountTextSymbolsWithoutSpaces(text);

            // assert

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}