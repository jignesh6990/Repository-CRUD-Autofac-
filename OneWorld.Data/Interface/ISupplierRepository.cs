using OneWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorld.Data
{
  public interface ISupplierRepository:IGenericRepository<Supplier>
    {
        IEnumerable<Supplier> GetAll();
    }
}
