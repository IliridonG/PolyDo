using MediatR;
using Domain.Interfaces.TaskRepository;
using Task = Domain.Entities.Tasks.Task;

namespace Application.Features.Tasks.Commands.Create
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand>
    {
        private readonly ITaskRepository _customerRepository;
        public CreateTaskCommandHandler(ITaskRepository customerRepository)
        {
            _customerRepository = customerRepository;

        }
        public async System.Threading.Tasks.Task Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var customer = Task.Create(request.Title, request.Description, request.DueDate, request.IsCompleted, request.Subtasks);
            await _customerRepository.AddAsync(customer);
        }
    }
}
