using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutDealDAO.Models
{
    public class DAOEmployee
    {
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(GlobalSettings.ConnectionString);
        }
        public DAOEmployee()
        {

        }
    }
}
