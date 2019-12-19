using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayToWin
{
    public class Purchase
    {
        public Userinos AccPurchase(int id)
        {
            foreach (Userinos user in Form1.usee)
            {
                if (user.ID.Equals(id))
                {

                    return user;
                }
            }

            return null;
        }
    }
}
