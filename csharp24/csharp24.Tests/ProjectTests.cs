using csharp24;

namespace Csharp24.Tests
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void CallingAddWith5And8Returns13()
        {
            // Arrange
            int number1 = 5;
            int number2 = 8;
            int expectedResult = 13;

            // Act
            int actualResult = Project.Add(number1, number2);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingAddWith100And3Returns103()
        {
            // arrange

            int number1 = 100;
            int number2 = 3;
            int expectedResult = 103;

            // act
            int actualResult = Project.Add(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingDifferenceWith10And5Returns5()
        {
            // arrange

            int number1 = 10;
            int number2 = 5;
            int expectedResult = 5;

            // act
            int actualResult = Project.Difference(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingDifferenceWith15And3Returns12()
        {
            // arrange

            int number1 = 15;
            int number2 = 3;
            int expectedResult = 12;

            // act
            int actualResult = Project.Difference(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingMultiplyWith10And5Returns50()
        {
            // Arrange
            int number1 = 10;
            int number2 = 5;
            int expectedResult = 50;

            // act
            int actualResult = Project.Multiply(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingMultiplyWith2And5Returns10()
        {
            // Arrange
            int number1 = 2;
            int number2 = 5;
            int expectedResult = 10;

            // act
            int actualResult = Project.Multiply(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingDivisionWith20And10Returns2()
        {
            // Arrange
            int number1 = 20;
            int number2 = 10;
            int expectedResult = 2;

            // act
            double actualResult = Project.Division(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingDivisionWith8And2Returns4()
        {
            // Arrange
            int number1 = 8;
            int number2 = 2;
            int expectedResult = 4;

            // act
            double actualResult = Project.Division(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}