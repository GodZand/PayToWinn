using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayToWin
{
    public class Autentic
    {
        
        public Userinos GetAuthenticatedUser(string username, string password)
        {
            foreach (Userinos user in Login.useriai)
            {
                if (user.Password.Equals(password) && user.Username.Equals(username))
                {
                    return user;
                }
            }

            
            return null;
        }
    }
}
