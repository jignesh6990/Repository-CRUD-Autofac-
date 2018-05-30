using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneWorld.Model;

namespace OneWorld.Service
{
  public interface ISupplierService:IEntityService<Supplier>
    {
        
        IEnumerable<Supplier> GetAllSupplier();  //Get All

        Supplier AddSupplier(Supplier supplier); //Add New Supplier

        bool UpdateSupplier(Supplier supplier); //Update Supplier details
    }
}
