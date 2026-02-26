using GymScheduler.Domain.Entities;
using GymScheduler.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ExerciseContext _context;
        public BaseRepository(ExerciseContext context)
        {
            _context = context;
        }
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }
        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
