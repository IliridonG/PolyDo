using Domain.Entities.Tasks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tasks.Commands.Update
{
    public record UpdateTaskCommand
    (
        int Id,
        string Title,
        string Description,
        DateTime DueDate,
        bool IsCompleted,
        List<Subtask> Subtasks
        ) : IRequest;
}
