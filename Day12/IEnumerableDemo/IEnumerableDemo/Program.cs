using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumarableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInfo[] uInfo = new UserInfo[3]
            {
                new UserInfo(1, "Karthik", "Chennai"),
                new UserInfo(2, "Anika", "Banglore"),
                new UserInfo(3, "Trishika", "Hyderabad")
            };
            Users users = new Users(uInfo);
            foreach (var user in users)
            {
                Console.WriteLine(user.Id + " " + user.Name + " " + user.Location);
            }
            Console.ReadLine();
        }
        public class UserInfo
        {
            public UserInfo(int id, string name, string location)
            {
                 this.Id = id;
                this.Name = name;
                this.Location = location;
            }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
        }
        public class Users : IEnumerable
        {
            private UserInfo[] _user;
            public Users(UserInfo[] uArray)
            {
                _user = new UserInfo[uArray.Length];
                for (int i = 0; i < uArray.Length; i++)
                {
                    _user[i] = uArray[i];
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }
            public UsersEnum GetEnumerator()
            {
                return new UsersEnum(_user);
            }
        }
        public class UsersEnum : IEnumerator
        {
            public UserInfo[] _user;
            int currentIndex = -1;
            public UsersEnum(UserInfo[] list)
            {
                _user = list;
            }
            public bool MoveNext()
            {
                currentIndex++;
                return (currentIndex < _user.Length);
            }
            public void Reset()
            {
                currentIndex = -1;
            }
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public UserInfo Current
            {
                get
                {
                    try
                    {
                        return _user[currentIndex];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}