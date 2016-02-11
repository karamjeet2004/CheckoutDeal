using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutDealDAO.Models
{
    public class GlobalSettings
    {
        public static string ConnectionString
        {
            get
            {
                return string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};",
                    "localhost", "3306", "checkoutdeal", "root", "root");
            }
        }
    }
}
