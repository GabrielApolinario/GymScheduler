using GymScheduler.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Application.UseCases
{
    public class CreateExerciseUseCase(IExerciseRepository repository)
    {
        private IExerciseRepository _repository = repository;
    }
}
