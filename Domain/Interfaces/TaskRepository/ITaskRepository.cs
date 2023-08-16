using Domain.Entities.Tasks.ValueObjects;
using Task = Domain.Entities.Tasks.Task;

namespace Domain.Interfaces.TaskRepository
{
    public interface ITaskRepository : IBaseRepository<Task, TaskId>
    {
    }
}
