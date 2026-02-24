using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Domain.Entities
{
    public sealed class Exercise(string name, string description, string targetMuscle)
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string? Name { get; set; } = name;
        public string? Description { get; set; } = description;
        public string? TargetMuscle { get; set; } = targetMuscle;
        public DateTime CreatedAt { get; } = DateTime.Now;
    }
}
