namespace csharp34.Tests
{
    [TestClass]
    public class FileMethodsTests
    {
        [TestMethod]
        public void CountWordsInFileWithGivenTextReturns14()
        {
            // Arrange
            string path = "C#.txt";
            string[] lines = {"C# is a programming language developed by Microsoft that runs on the .NET Framework."};
            
            File.WriteAllLines(path, lines);

            // Act
            int wordCount = FileMethods.CountWordsInFile(path);

            // Assert
            Assert.AreEqual(14, wordCount); 
        }

        [TestMethod]
        public void CountWordsInFileWithGivenTextReturns5()
        {
            // Arrange
            string testFilePath = "C#.txt";
            string[] lines = {"Laba diena, mano vardas Petras"};

            File.WriteAllLines(testFilePath, lines);

            // Act
            int wordCount = FileMethods.CountWordsInFile(testFilePath);

            // Assert
            Assert.AreEqual(5, wordCount);
        }

        [TestMethod]
        public void CountWordsInFileWithNullReturnsException()
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => FileMethods.CountWordsInFile(null));
        }
    }
}