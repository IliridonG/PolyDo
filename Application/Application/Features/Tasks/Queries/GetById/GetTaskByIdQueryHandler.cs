using Application.Features.Tasks.DTOs;
using Domain.Entities.Tasks.ValueObjects;
using Domain.Interfaces.TaskRepository;
using MapsterMapper;
using MediatR;

namespace Application.Features.Tasks.Queries.GetById
{
    public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, TaskDTO>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public GetTaskByIdQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskDTO> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var task = await _taskRepository.GetByIdAsync(TaskId.Create(request.Id));
            return _mapper.Map<TaskDTO>(task);
        }
    }
}
