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
    public class AppointmentManagerTests
    {
        [TestMethod()]
        public void checkIfTimeIsValid_StartTimeValid_ReturnsTrue()
        {
            var appointmentManager = new AppointmentManager();
            var startTime = "2019-01-01 12:00:00";
            var result = appointmentManager.checkIfTimeIsValid(startTime);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void checkIfTimeIsValid_StartTimeInvalid_ReturnsFalse()
        {
            var appointmentManager = new AppointmentManager();
            var startTime = "2019-01-01 22:00:00";
            var result = appointmentManager.checkIfTimeIsValid(startTime);
            Assert.IsFalse(result);
        }
    }
}