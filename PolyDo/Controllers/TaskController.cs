using MediatR;
using MapsterMapper;
using Contracts.Task;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Tasks.Commands.Create;
using Application.Features.Tasks.Commands.Update;
using Application.Features.Tasks.Commands.Delete;
using Application.Features.Tasks.Queries.GetById;
using Application.Features.Tasks.Queries.ListAll;

namespace PolyDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new ListAllTasksQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = _mapper.Map<GetTaskByIdQuery>(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateTaskRequest createTaskRequest)
        {
            var command = _mapper.Map<CreateTaskCommand>(createTaskRequest);
            await _mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateTaskRequest updateTaskRequest)
        {
            var command = _mapper.Map<UpdateTaskCommand>(updateTaskRequest);
            await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = _mapper.Map<DeleteTaskCommand>(id);
            await _mediator.Send(command);
            return Ok();
        }
    }
}
