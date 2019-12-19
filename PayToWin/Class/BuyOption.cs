using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayToWin
{
    public class BuyOption
    {
        public int Amount { get; set; }
        public int Price { get; set; }

        public string Infopric
        {
            get
            {
                return $"{Amount} WinPoints      {Price} Eur";
            }
        }
    }
}
