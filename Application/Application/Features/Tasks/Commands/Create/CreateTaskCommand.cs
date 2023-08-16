using Domain.Entities.Tasks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tasks.Commands.Create
{
    public record CreateTaskCommand
    (
        string Title,
        string Description,
        DateTime DueDate,
        bool IsCompleted,
        List<Subtask> Subtasks
    ) : IRequest;
}
