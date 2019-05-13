using Kata003.Models;
using System;
using Xunit;

namespace Kata003.Test
{
    public class UserTests
    {
        [Fact]
        public void Test1()
        {
            var u = new User(1);
            u.Expires = DateTime.UtcNow.AddDays(-4);
            u.ResetExpires();
            var future = DateTime.UtcNow.AddDays(60);
            Assert.Equal(future, u.Expires);
        }
    }
}
