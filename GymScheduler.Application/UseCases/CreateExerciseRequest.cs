using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Application.UseCases
{
    public sealed record CreateExerciseRequest(string Name, string Description, string TargetMuscle, string? ExecutionVideoUrl) : IRequest<CreateExerciseResponse>;
}