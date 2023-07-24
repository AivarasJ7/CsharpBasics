using csharp26_3;

namespace csharp26_3.Tests
{
    [TestClass]
    public class RegistrationSystemTests
    {
        [TestMethod]
        public void CallingAddUserWithPetrasAndPassword()
        {
            // Arrange
            RegistrationSystem registrationSystem = new RegistrationSystem();

            // Act
            registrationSystem.AddUser("Petras", "password");

            // Assert
            Assert.IsTrue(registrationSystem.CheckIfUserExists("Petras"));
        }

        [TestMethod]
        public void CallingAddUserWithJonasAndPassword2()
        {
            // Arrange
            RegistrationSystem registrationSystem = new RegistrationSystem();

            // Act
            registrationSystem.AddUser("Jonas", "Password2");

            // Assert
            Assert.IsTrue(registrationSystem.CheckIfUserExists("Jonas"));
        }


        [TestMethod]
        public void CallingCheckIfUserExistsWithDariusPass1()
        {
            // Arrange
            RegistrationSystem registrationSystem = new RegistrationSystem();
            string username = "Darius";
            string password = "Pass1";
            registrationSystem.AddUser(username, password);

            // Act
            bool userExists = registrationSystem.CheckIfUserExists(username);

            // Assert
            Assert.IsTrue(userExists);
        }

        [TestMethod]
        public void CallingCheckIfUserExistsWithAntanasPass2()
        {
            // Arrange
            RegistrationSystem registrationSystem = new RegistrationSystem();
            string username = "Antanas";
            string password = "Pass2";
            registrationSystem.AddUser(username, password);

            // Act
            bool userExists = registrationSystem.CheckIfUserExists(username);

            // Assert
            Assert.IsTrue(userExists);
        }

        [TestMethod]
        public void CallingLoginWithKazysPass3()
        {
            // Arrange
            RegistrationSystem registrationSystem = new RegistrationSystem();
            registrationSystem.AddUser("Kazys", "Pass3");

            // Act
            bool isLoggedIn = registrationSystem.Login("Kazys", "Pass3");

            // Assert
            Assert.IsTrue(isLoggedIn);
        }

        [TestMethod]
        public void CallingLoginWithVardasPass5()
        {
            // Arrange
            RegistrationSystem registrationSystem = new RegistrationSystem();
            registrationSystem.AddUser("Vardas", "Pass5");

            // Act
            bool isLoggedIn = registrationSystem.Login("Vardas", "Pass5");

            // Assert
            Assert.IsTrue(isLoggedIn);
        }
    }
}