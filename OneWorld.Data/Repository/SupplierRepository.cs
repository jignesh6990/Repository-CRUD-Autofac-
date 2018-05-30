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


        /// <summary>
        /// Get All Suppliers
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Supplier> GetAll()
        {
            return _entities.Set<Supplier>().AsEnumerable();
         
        }

        /// <summary>
        /// Add New Supplier
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        public Supplier AddSupplier(Supplier supplier)
        {               
            _entities.Entry(supplier).State=EntityState.Added;
            _entities.SaveChanges();
            return supplier;
        }

        /// <summary>
        /// Update supplier details
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        public bool UpdateSupplier(Supplier supplier)
        {
            bool isSuccess = false;
            try
            {
                _entities.Entry(supplier).State = EntityState.Modified;
                _entities.SaveChanges();
                isSuccess = true;
            }
            catch(Exception ex)
            {
                
            }
            return isSuccess;
        }

        /// <summary>
        /// Get Supplier by SupplierId
        /// </summary>
        /// <param name="supplierId"></param>
        /// <returns></returns>
        public Supplier GetSupplierById(int supplierId)
        {
            Supplier supplier = new Supplier();
            if(supplierId>0)
            {
                supplier=_entities.Set<Supplier>().Where(p => p.Id == supplierId).FirstOrDefault();
            }
            return supplier;
        }
    }
}
