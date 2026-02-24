using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Domain.Entities
{
    public sealed class Training(string name, string description, IEnumerable<Exercise> exercises)
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public IEnumerable<Exercise> Exercises { get; set; } = exercises;
        public DateTime CreatedAt { get; } = DateTime.Now;

    }
}
