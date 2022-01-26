using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceTest.Resources.Interface
{
    public class UserRepository
    {
        public List<object> GetAllUsers()
        {
            //Go to the database and fetch all users. 

            List<object> _users = new List<object>();
            return  _users;
    }

        public void Insert(object user)
        {
            //Insert a user into the database here. 
        }
    }
}
