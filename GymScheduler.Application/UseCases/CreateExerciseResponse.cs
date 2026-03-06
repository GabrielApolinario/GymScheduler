using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Application.UseCases
{
    public sealed record CreateExerciseResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
