using csharp26_3;

namespace csharp26_3.Tests
{
    [TestClass]
    public class RegistrationSystemTests
    {
        [TestMethod]
        public void CallingAddUserWithJonasPass1()
        {
            // Arrange
             Dictionary<string, string> userStorage;

            userStorage userManager = new userStorage();
            string username = "Jonas";
            string password = "Pass1";

            // Act
            userManager.AddUser(username, password);

            // Assert
            Assert.IsTrue(userManager.users.ContainsKey(username));
            Assert.AreEqual(password, userManager.users[username]);

            // not finished...
        }
    }
}