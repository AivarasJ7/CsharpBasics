namespace csharp34.Tests
{
    [TestClass]
    public class FileMethodsTests
    {
        [TestMethod]
        public void ProcessFileOnReadingAndCountWordsReturnsCount14()
        {
            // Arrange
            string path = "C#.txt";
            string[] lines = new string[]
            {
            "C# is a programming language developed by Microsoft that runs on the .NET Framework."
            };

            // Act
            int wordCount = FileMethods.ProcessFileOnReadingAndCountWords(path, "C#");

            // Assert
            Assert.AreEqual(14, wordCount);
        }
    }
}