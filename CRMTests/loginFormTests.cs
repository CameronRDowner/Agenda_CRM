using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Tests
{
    [TestClass()]
    public class loginFormTests
    {
        [TestMethod()]
        public void checkIfLoginValid_InvalidUsernameAndPassword_ReturnsFalse()
        {
            var loginForm = new loginForm();
            var username = "wronguser";
            var password = "wrongpass";
            var result = loginForm.checkIfLoginValid(username, password);

            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void checkIfLoginValid_InvalidPassword_ReturnsFalse()
        {
            var loginForm = new loginForm();
            var username = "test";
            var password = "wrongpass";
            var result = loginForm.checkIfLoginValid(username, password);

            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void checkIfLoginValid_ValidUsernameAndPassword_ReturnsTrue()
        {
            var loginForm = new loginForm();
            var username = "test";
            var password = "test";
            var result = loginForm.checkIfLoginValid(username, password);

            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void checkIfLoginValid_InvalidUsername_ReturnsFalse()
        {
            var loginForm = new loginForm();
            var username = "wronguser";
            var password = "test";
            var result = loginForm.checkIfLoginValid(username, password);

            Assert.IsFalse(result);
        }
    }
}