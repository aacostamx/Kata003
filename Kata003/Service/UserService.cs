using Kata003.Interface;
using Kata003.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Kata003.Service
{
    public class UserService : IUserService
    {
        public void CreateUserName()
        {
            throw new NotImplementedException();
        }

        public bool FindByCondition(Expression<Func<bool, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void ResetExpires()
        {
            throw new NotImplementedException();
        }

        public void UpdateExpiredDateInternal()
        {
            throw new NotImplementedException();
        }
    }
}
