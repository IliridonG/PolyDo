using Application.Features.Tasks.DTOs;
using Domain.Interfaces.TaskRepository;
using MapsterMapper;
using MediatR;

namespace Application.Features.Tasks.Queries.ListAll
{
    public class ListAllTasksQueryHandler : IRequestHandler<ListAllTasksQuery, List<TaskDTO>>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public ListAllTasksQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<TaskDTO>> Handle(ListAllTasksQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<TaskDTO>>(await _taskRepository.GetAllAsync());
        }
    }
}
