using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneWorld.Model;
using System.Data.Entity.ModelConfiguration.Conventions;
using OneWorld.Data.Configuration;
namespace OneWorld.Data
{
   public class ERDDBContext: DbContext
    {
        public ERDDBContext():base("DBConnection")
        {
            Database.SetInitializer<ERDDBContext>(null);
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Supplier> Supplier { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new SupplierConfiguration());
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}
