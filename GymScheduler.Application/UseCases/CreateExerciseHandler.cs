using AutoMapper;
using GymScheduler.Domain.Entities;
using GymScheduler.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Application.UseCases
{
    public class CreateExerciseHandler : IRequestHandler<CreateExerciseRequest, CreateExerciseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IExerciseRepository _repository;
        private readonly IMapper _mapper;

        public CreateExerciseHandler(IUnitOfWork unitOfWork, IExerciseRepository repository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;

        }

        public async Task<CreateExerciseResponse> Handle(CreateExerciseRequest request, CancellationToken cancellationToken)
        {
            var exercise = _mapper.Map<Exercise>(request);

            _repository.Create(exercise);

            await _unitOfWork.Commit(cancellationToken);
            
            return _mapper.Map<CreateExerciseResponse>(exercise);
        }
    }
}
