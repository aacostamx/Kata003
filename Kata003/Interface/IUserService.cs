using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Kata003.Interface
{
    public interface IUserService
    {
        void CreateUserName();
        void UpdateExpiredDateInternal();
        void ResetExpires();
        bool FindByCondition(Expression<Func<bool, bool>> expression);
    }
}
