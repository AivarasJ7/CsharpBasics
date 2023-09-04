
using FluentAssertions;
using System.Drawing;

namespace cs_klases_darbas_2.Tests
{
    [TestClass]
    public class CustomerListsConverterTests
    {
        [TestMethod]
        public void CallingConvertWithWrongLinesReturnsEmptyList()
        {
            //arrange
            CustomerListConverter converter = new CustomerListConverter();
            List<string> lines = new List<string>()
            {
             "sveiki, nera, kableliu",
            "sveiki, nera, kableliu, aa",
            "sveiki, nera, kableliu, aa",
            "sveiki, nera",
            };

            List<Customer> expectedResult = new List<Customer>();
            
            //act
            List<Customer> actualResult = converter.Convert(lines);

            //assert
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void CallingConvertWithCorrectLinesReturnsListOfCustomers()
        {
            //arrange
            CustomerListConverter converter = new CustomerListConverter();
            List<string> lines = new List<string>()
            {
             "3,Temp Feasey,tfeasey2@wikimedia.org,Male,PO Box 89067,202038"
            };

            List<Customer> expectedResult = new List<Customer>()
            {
                new Customer(
                    3,
                    "Temp",
                    "Feasey",
                    "tfeasey2@wikimedia.org",
                    Gender.Male,
                    "PO Box 89067",
                    "202038"
                    )
            };
            //act
            List<Customer> actualResult = converter.Convert(lines);

            //assert
            actualResult.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void CallingConvertWithThreeCorrectLinesReturnsListOfCustomers()
        {
            //arrange
            CustomerListConverter converter = new CustomerListConverter();
            List<string> lines = new List<string>()
            {
             "3,Temp Feasey,tfeasey2@wikimedia.org,Male,PO Box 89067,202038",
             "12,Daffie Marcam,dmarcamb@amazonaws.com,Female,Suite 81,58120",
            "13,Brynn Grimbaldeston,bgrimbaldestonc@booking.com,Female,5th Floor,353250"
            };

            List<Customer> expectedResult = new List<Customer>()
            {
                new Customer(
                    3,
                    "Temp",
                    "Feasey",
                    "tfeasey2@wikimedia.org",
                    Gender.Male,
                    "PO Box 89067",
                    "202038"
                    ),

                new Customer(
                    12,
                    "Daffie",
                    "Marcam",
                    "dmarcamb@amazonaws.com",
                    Gender.Female,
                    "Suite 81",
                    "58120"
                    ),

                new Customer(
                    13,
                    "Brynn",
                    "Grimbaldeston",
                    "bgrimbaldestonc@booking.com",
                    Gender.Female,
                    "5th Floor",
                    "353250"
                    )
            };
            //act
            List<Customer> actualResult = converter.Convert(lines);

            //assert
            expectedResult.Should().BeEquivalentTo(actualResult);
        }

        [TestMethod]
        public void CallingConvertWithWhichHasGenderWithDashSuccessfullyConvertsToCorrectGender()
        {
            //arrange
            CustomerListConverter converter = new CustomerListConverter();
            List<string> lines = new List<string>()
            {
             "209,Marti Tante,mtante5s@sogou.com,Non-binary,Room 1815,"
            };

            //act
            List<Customer> actualResult = converter.Convert(lines);

            //assert
            Assert.AreEqual(Gender.Nonbinary, actualResult[0].Gender);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ThrowsNotSupportedExceptionWhenLineContainsGenderThatDoesNotExist()
        {
            //arrange
            CustomerListConverter converter = new CustomerListConverter();
            List<string> lines = new List<string>()
            {
                "12,Daffie Marcam,dmarcamb@amazonaws.com,Non-existing,Suite 81,58120"
            };

            //act
            converter.Convert(lines);
        }
    }
}
