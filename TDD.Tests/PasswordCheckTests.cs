using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Tests
{
    [TestClass]
    public class PasswordCheckTests
    {
        [TestMethod]
        public void IfNoPassword()
        {
            //Arrange
            string password = "";
            int expected = 0;

            //Act
            int actual = PasswordCheck.PasswordStrength(password);

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void IfSmallPassword()
        {
            //Arrange
            string password = "Passw";
            int expected = 1;

            //Act
            int actual = PasswordCheck.PasswordStrength(password);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void IfMediumPassword()
        {
            //Arrange
            string password = "Password";
            int expected = 2;

            //Act
            int actual = PasswordCheck.PasswordStrength(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IfPasswordContainsSpecialCharacters()
        {
            //Arrange
            string password = "Pass@#d";
            string expected = "Valid";

            //Act
            string actual = PasswordCheck.PasswordRegexCheck(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IfPasswordContainsNumbers()
        {
            //Arrange
            string password = "Pass01";
            string expected = "Valid";

            //Act
            string actual = PasswordCheck.PasswordNumberCheck(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IfComplexPassword()
        {
            //Arrange
            string password = "Pass@1word";
            string expected = "Valid";

            //Act
            string actual = PasswordCheck.ComplexPasswordCheck(password);

            Assert.AreEqual(expected, actual);
        }
    }
}
