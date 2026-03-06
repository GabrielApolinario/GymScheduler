using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymScheduler.Domain.Entities;

namespace GymScheduler.Application.UseCases
{
    public sealed class CreateExerciseMapper : Profile
    {
        public CreateExerciseMapper()
        {
            CreateMap<CreateExerciseRequest, Exercise>();
            CreateMap<Exercise, CreateExerciseResponse>();
        }
    }
}
