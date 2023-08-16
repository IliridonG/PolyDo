using Application.Features.Tasks.DTOs;
using MediatR;

namespace Application.Features.Tasks.Queries.GetById
{
    public record GetTaskByIdQuery
    (
        int Id
        ) : IRequest<TaskDTO>;
}
