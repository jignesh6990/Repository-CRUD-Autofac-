using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneWorld.Model;
using OneWorld.Data;

namespace OneWorld.Service
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitofWork"></param>
        /// <param name="repository"></param>
        public EntityService(IUnitOfWork unitofWork,IGenericRepository<T> repository)
        {
            _unitOfWork = unitofWork;
            _repository = repository;
        }

        /// <summary>
        /// Add new data
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            if(entity==null)
            {
                throw new ArgumentException("Entity is null");
            }
            _repository.Add(entity);
            _unitOfWork.Commit();

        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Entity is null");
            }
            _repository.Delete(entity);
            _unitOfWork.Commit();

        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Entity is null");
            }
            _repository.Edit(entity);
            _unitOfWork.Commit();
        }
    }
}
