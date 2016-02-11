using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutDealDAO.Entities
{
    [Table("user")]
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
