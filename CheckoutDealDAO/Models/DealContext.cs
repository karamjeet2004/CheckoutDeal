using CheckoutDealDAO.Entities;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutDealDAO.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DealContext: DbContext
    {
        public DealContext() :  base()
        {

        }

        public DealContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
 
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().MapToStoredProcedures();
        }
        public DbSet<User> Users { get; set; }
    }
}
