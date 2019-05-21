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

        /// <summary>
        /// ID must be bigger than 100 and Expire less than UtcNow - 5 days
        /// </summary>
        [Fact]
        public void Update_Expired_Date_Internal_Ten()
        {
            // Arrange
            var user = new User(101, "Antonio", "Acosta")
            {
                // Act
                Expires = DateTime.UtcNow.AddDays(-5)
            };
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
                // Act
                Expires = DateTime.UtcNow.AddDays(-3)
            };
            user.UpdateExpiredDateInternal();

            // Assert
            Assert.Equal(DateTime.UtcNow.AddDays(60).Date, user.Expires.Date);
        }


    }
}
