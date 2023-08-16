using Domain.Entities.Tasks.ValueObjects;
using Domain.Interfaces.TaskRepository;
using MediatR;

namespace Application.Features.Tasks.Commands.Update
{
    public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand>
    {
        private readonly ITaskRepository _taskRepository;

        public UpdateTaskCommandHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskRepository.GetByIdAsync(TaskId.Create(request.Id));

            if (task is not null)
            {
                task.SetTitle(request.Title);
                task.SetDescription(request.Description);   
                task.SetDueDate(request.DueDate);
                task.SetIsCompleted(request.IsCompleted);
                task.SetSubtask(request.Subtasks);
                await _taskRepository.UpdateAsync(task);
            }
        }
    }
}
