using GymScheduler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Domain.Interfaces
{
    public interface IExerciseRepository
    {
        Task AddAsync(Exercise exercise);
        Task UpdateAsync(Exercise exercise);
        Task DeleteAsync(Exercise exercise);
        Task<Exercise> GetByIdAsync(int id);
        Task<Exercise> GetAllAsync();
    }
}
