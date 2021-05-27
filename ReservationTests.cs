using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests // same name as project add .UnitTests when saving
{
    [TestClass]
    public class ReservationTests // name of class + test
    {
        [TestMethod] // test class attribute
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue() // method being tested_scenario_expected behavior
        {

            // Arrange: init objects
            var reservation = new Reservation();

            // Act: act on the object
            result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert: verify result is true
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };

            reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }
}
