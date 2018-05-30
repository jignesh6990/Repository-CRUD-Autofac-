using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneWorld.Model;
using System.Data.Entity;

namespace OneWorld.Data.Repository
{
   public class SupplierRepository:GenericRepository<Supplier>,ISupplierRepository
    {
        public SupplierRepository(IDatabaseFactory dbFactory)
            :base(dbFactory)
        { }

        public override IEnumerable<Supplier> GetAll()
        {
            return _entities.Set<Supplier>().AsEnumerable();
         
        }


    }
}
