using System;
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
        public bool ID_Greater_Than(int number) => ID > number;
        public bool ID_Less_Than(int number) => ID < number;
        public bool Expires_Less_Than(int number) => Expires < DateTime.UtcNow.AddDays(number);
        public bool Expires_Less_Than_Now() => Expires < DateTime.UtcNow;

        public User(int id, string firstName = "", string lastName = "")
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Created = DateTime.UtcNow;
            CreateUserName();
            UpdateExpiredDateInternal();
        }

        public void CreateUserName()
        {
            UserName = $"{ID}_{LastName}";
        }

        public void UpdateExpiredDateInternal()
        {
            if (ID_Greater_Than(100) && Expires_Less_Than(-5))
            {
                Expires = DateTime.UtcNow.AddDays(10);
            }
            else if (Expires_Less_Than_Now())
            {
                if (ID_Less_Than(10) || ID_Greater_Than(80))
                {
                    if (Expires_Less_Than(5))
                    {
                        Expires = DateTime.UtcNow.AddDays(60);
                    }
                }
            }
            else
            {
                Expires = DateTime.UtcNow.AddDays(10);
            }
        }

        public void ResetExpires()
        {
            var rnd = new Random();
            if (rnd.Next(1, 10) < 5) Thread.Sleep(3000);
            UpdateExpiredDateInternal();
        }
    }
}
