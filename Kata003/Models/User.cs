using System;
using System.Linq.Expressions;
using System.Threading;

namespace Kata003.Models
{
    public class User
    {
        public string UserName { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int ID { get; private set; }
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }

        public User(int id, string firstName = "", string lastName = "")
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Created = DateTime.UtcNow;
        }

        public void CreateUserName() => UserName = $"{ID}_{LastName}";

        public void UpdateExpiredDateInternal()
        {
            if (ID > 100 && Expires < DateTime.UtcNow.AddDays(-5))
            {
                Expires = DateTime.UtcNow.AddDays(10);
            }
            else if (Expires < DateTime.UtcNow)
            {
                if (ID < 10 || ID > 80)
                {
                    if (Expires < DateTime.UtcNow.AddDays(5))
                    {
                        Expires = DateTime.UtcNow.AddDays(60);
                    }
                    else
                    {
                        //if (Expires > DateTime.UtcNow)
                        //{
                        //    Expires = DateTime.UtcNow.AddDays(90);
                        //}
                        //else
                        //{
                            Expires = DateTime.UtcNow.AddDays(70);
                        //}
                    }
                }

            }
            //else if (Expires < DateTime.UtcNow && ID < 1000)
            //{
            //    Expires = DateTime.UtcNow.AddDays(100);
            //}
            else
            {
                Expires = DateTime.UtcNow.AddDays(10);
            }
        }

        //private bool FindByCondition(Expression<Func<bool, bool>> expression)
        //{
        //    var user = new User(11, "Antonio", "Acosta");
        //    return user.(expression);
        //}

        public void ResetExpires()
        {
            var rnd = new Random();
            if (rnd.Next(1, 10) < 5) Thread.Sleep(3000);
            UpdateExpiredDateInternal();
        }
    }
}
