using GymScheduler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Infrastructure.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public Task<T> GetById(Guid id, CancellationToken cancellationToken);
        public Task<T> GetAll(CancellationToken cancellationToken);

    }
}
