using GymScheduler.Domain.Entities;
using GymScheduler.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Infrastructure.Repositories
{
    public class ExerciseRepository : IRepository<Exercise>
    {
        private readonly ExerciseContext _context;
        public ExerciseRepository(ExerciseContext context)
        {
            _context = context;
        }
    }
}
