using Kata003.Models;
using System;
using Xunit;

namespace Kata003.Test
{
    public class UserTests
    {
        [Fact]
        public void Create_UserName()
        {
            // Arrange
            var user = new User(1, "Antonio", "Acosta");

            // Act         
            user.CreateUserName();

            // Assert
            Assert.Equal("1_Acosta", user.UserName);
        }

        [Fact]
        public void Update_Expired_Date_Internal_Default()
        {
            // Arrange
            var user = new User(11, "Antonio", "Acosta");

            // Act
            user.UpdateExpiredDateInternal();

            // Assert
            Assert.Equal(default, user.Expires.Date);
        }

        [Fact]
        public void Update_Expired_Date_Internal_Ten()
        {
            // Arrange
            var user = new User(101, "Antonio", "Acosta")
            {
                Expires = DateTime.UtcNow.AddDays(-5)
            };

            //Act
            user.UpdateExpiredDateInternal();

            // Assert
            Assert.Equal(DateTime.UtcNow.AddDays(10).Date, user.Expires.Date);
        }

        [Fact]
        public void Update_Expired_Date_Internal_Sixty()
        {
            // Arrange
            var user = new User(101, "Antonio", "Acosta")
            {
                Expires = DateTime.UtcNow.AddDays(-3)
            };

            //Act
            user.UpdateExpiredDateInternal();

            // Assert
            Assert.Equal(DateTime.UtcNow.AddDays(60).Date, user.Expires.Date);
        }


        [Fact]
        public void Update_Expired_Date_Internal_Ten_Else()
        {
            // Arrange
            var user = new User(11, "Antonio", "Acosta")
            {
                Expires = DateTime.UtcNow.AddDays(1)
            };

            //Act
            user.UpdateExpiredDateInternal();

            // Assert
            Assert.Equal(DateTime.UtcNow.AddDays(10).Date, user.Expires.Date);
        }

        [Fact]
        public void Reset_Expires()
        {
            var user = new User(101, "Antonio", "Acosta")
            {
                Expires = DateTime.UtcNow.AddDays(100)
            };

            //Act
            user.ResetExpires();

            // Assert
            Assert.NotNull(user);
        }

    }
}
