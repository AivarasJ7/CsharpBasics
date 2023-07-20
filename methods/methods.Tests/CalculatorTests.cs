namespace methods.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CallingAddWith2And3Returns5()
        {
            // arrange - pasiruosiam
            int number1 = 2;
            int number2 = 3;
            int expectedResult = 5;

            // act - paleidziam
            int actualResult = Calculator.Add(number1, number2);

            // assert - patikrinam

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
            int actualResult = Calculator.Add(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CallingDivideWith91And10ReturnsQuetient9AndRemainder1()
        {
            //arrange
            int expectedQuetient = 9;
            int expectedRemainder = 1;

            //act
            Calculator.Divide(
                91, 
                10, 
                out int actualQuetient, 
                out int actualRemainder
            );

            //assert
            Assert.AreEqual(expectedQuetient, actualQuetient);
            Assert.AreEqual(expectedRemainder, actualRemainder);
        }

        [TestMethod]
        public void CallingDivideWith86And10ReturnsQuetient8AndRemainder6()
        {
            //arrange
            int expectedQuetient = 8;
            int expectedRemainder = 6;

            //act
            Calculator.Divide(
                86,
                10,
                out int actualQuetient,
                out int actualRemainder
            );

            //assert
            Assert.AreEqual(expectedQuetient, actualQuetient);
            Assert.AreEqual(expectedRemainder, actualRemainder);
        }
    }
}