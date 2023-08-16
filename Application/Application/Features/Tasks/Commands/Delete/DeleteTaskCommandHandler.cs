using Domain.Entities.Tasks.ValueObjects;
using Domain.Interfaces.TaskRepository;
using MediatR;

namespace Application.Features.Tasks.Commands.Delete
{
    public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand>
    {
        private readonly ITaskRepository _taskRepository;

        public DeleteTaskCommandHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            await _taskRepository.DeleteAsync(TaskId.Create(request.Id));
        }
    }
}
