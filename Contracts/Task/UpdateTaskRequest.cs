using Domain.Entities.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Task
{
    public record UpdateTaskRequest
    (
        int Id,
        string Title,
        string Description,
        DateTime DueDate,
        bool IsCompleted,
        List<Subtask> Subtasks
        );
}
