using Domain.Entities.Tasks;

namespace Application.Features.Tasks.DTOs
{
    public record TaskDTO
    (
        int Id,
        string Title,
        string Description,
        DateTime DueDate,
        bool IsCompleted,
        List<Subtask> Subtasks
        );
}
