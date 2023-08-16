using Application.Features.Tasks.DTOs;
using Domain.Entities.Tasks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Domain.Entities.Tasks.Task;

namespace Application.Features.Tasks.Queries.ListAll
{
    public record ListAllTasksQuery() : IRequest<List<TaskDTO>>;
}
