using csharp26_2;

namespace csharp26_2.Tests
{
    [TestClass]
    public class ReverseAlphabeticalSortingTests
    {
        [TestMethod]
        public void CallingSortWordsReverseAlphabeticalWithWordsNamasAnanasasBebrasLaikrodisDurys()
        {
            // Arrange
            List<string> words = new List<string>()
            {
                "Namas",
                "Ananasas",
                "Bebras",
                "Laikrodis",
                "Durys"
            };

            List<string> expectedResult = new List<string>()
            {
                "Namas",
                "Laikrodis",
                "Durys",
                "Bebras",
                "Ananasas"
            };

            // Act
            List<string> actualResult = ReverseAlphabeticalSorting.SortWordsReverseAlphabetical(words);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingSortWordsReverseAlphabeticalWithWordsLabasPetrasKatinasBatasVanduo()
        {
            // Arrange
            List<string> words2 = new List<string>()
            {
                "Labas",
                "Petras",
                "Katinas",
                "Batas",
                "Vanduo"
            };

            List<string> expectedResult = new List<string>()
            {
                "Vanduo",
                "Petras",
                "Labas",
                "Katinas",
                "Batas"
            };

            // Act
            List<string> actualResult = ReverseAlphabeticalSorting.SortWordsReverseAlphabetical(words2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}