namespace cs_klases_darbas_2.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CallingGetInfoReturnsLineWithDataFromClassProperties()
        {
            // arrange
            Customer customer = new Customer(
                1,
                "Jonas",
                "Jonaitis",
                "Jonas@gmail.com",
                Gender.Male,
                "Miesto g. 2"
                );

            string expectedResult = "Jonas Jonaitis. Jo el.pastas yra Jonas@gmail.com";

            //act
            string actualResult = customer.GetInfo();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}