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

        IEnumerable<Supplier> ISupplierService.GetAllSupplier()
        {
           return _repository.GetAll();
        }

        //List<Supplier> ISupplierService.GetAllSupplier()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
