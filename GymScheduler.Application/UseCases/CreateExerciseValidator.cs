using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Application.UseCases
{
    public sealed class CreateExerciseValidator : AbstractValidator<CreateExerciseRequest>
    {
        public CreateExerciseValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O nome do exercício é obrigatório.")
                .MaximumLength(100)
                .WithMessage("O nome do exercício não deve exceder 100 caracteres.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("A descrição do exercício é obrigatória.")
                .MaximumLength(500)
                .WithMessage("A descrição do exercício não deve exceder 500 caracteres.");

            RuleFor(x => x.TargetMuscle)
                .NotEmpty()
                .WithMessage("O músculo alvo do exercício é obrigatório.")
                .MaximumLength(50)
                .WithMessage("O músculo alvo do exercício não deve exceder 100 caracteres.");

                RuleFor(x => x.ExecutionVideoUrl)
                .MaximumLength(500)
                .WithMessage("O link do vídeo de execução não deve exceder 500 caracteres.");
        }
    }
}
