using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Domain.Entities
{
    public sealed class SetRepScheme(Exercise exercise, int sets, int reps) : BaseEntity
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Exercise Exercise { get; } = exercise;
        public int Sets { get; set; } = sets;
        public int Reps { get; set; } = reps;
        public bool IsCompleted { get; set; }
    }
}
