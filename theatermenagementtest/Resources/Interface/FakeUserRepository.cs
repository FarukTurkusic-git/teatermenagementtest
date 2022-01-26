using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceTest.Resources.Interface
{
    public class FakeUserRepository : IUserRepository
    {
        private List<object> _users = new List<object>();

        public List<object> GetAllUsers()
        {
            return _users;
        }

        public void Insert(object user)
        {
            _users.Add(user);
        }
    }
}
