using GymScheduler.Application.UseCases;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymScheduler.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;

        public ExerciseController(IMediator mediator, IConfiguration configuration)
        {
            _mediator = mediator;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult<CreateExerciseResponse>> Create(string pwd, CreateExerciseRequest request, CancellationToken cancellationToken)
        {
            //Proposito de teste
            if(pwd != _configuration["ApiPwd"])
            {
                return Unauthorized();
            }

            var validator = new CreateExerciseValidator();

            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
