using NUnit.Framework;

using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{

    [TestFixture]
    public class ReservationsTest
    {
        [Test]
        public void CanBeCancelled_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelled_SameUserWhoCreated_ReturnsTrue()
        {
            var user = new User();

            // Assert
            var reservation = new Reservation{MadeBy = user};

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelled_NoneAdminUserWhoDidNotCreate_ReturnsFalse()
        {
            // Assert
            var reservation = new Reservation {MadeBy = new User()};

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }
    }
}