using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneWorld.Model;
namespace OneWorld.Data
{
   public class ERDDBContext: DbContext
    {
        public ERDDBContext():base("Name:ERDConnection")
        {

        }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
