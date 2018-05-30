using OneWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorld.Data
{
    public interface ISupplierRepository : IGenericRepository<Supplier>
    {
        IEnumerable<Supplier> GetAll(); //Get All Suppliers

        Supplier AddSupplier(Supplier supplier); //Add New Supplier

        bool UpdateSupplier(Supplier supplier); //Update supplier details

        Supplier GetSupplierById(int supplierId); //Get supplier
    }
}
