using OneWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneWorld.Data;
using OneWorld.Data.Repository;

namespace OneWorld.Service
{
    public class SupplierService : EntityService<Supplier>, ISupplierService
    {
        IUnitOfWork _unitofWork;
        ISupplierRepository _repository;
        public SupplierService(IUnitOfWork unitofWork, ISupplierRepository repository) : base(unitofWork, repository)
        {
            _unitofWork = unitofWork;
            _repository = repository;
        }

        /// <summary>
        /// Get All Suppliers
        /// </summary>
        /// <returns></returns>
        IEnumerable<Supplier> ISupplierService.GetAllSupplier()
        {
            return _repository.GetAll();
        }

        /// <summary>
        /// Add Supplier
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        Supplier ISupplierService.AddSupplier(Supplier supplier)
        {
            return _repository.AddSupplier(supplier);
        }

        /// <summary>
        /// Update Supplier details
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        bool ISupplierService.UpdateSupplier(Supplier supplier)
        {
            bool isSuccess = false;
            Supplier supplierUser = _repository.GetSupplierById(supplier.Id);
            if (supplierUser != null && supplierUser.Id > 0)
            {
              isSuccess= _repository.UpdateSupplier(supplier);
            }

            return isSuccess;
        }

    }
}
