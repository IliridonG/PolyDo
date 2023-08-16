using Application.Features.Tasks.Commands.Delete;
using Application.Features.Tasks.DTOs;
using Application.Features.Tasks.Queries.GetById;
using Mapster;
using Task = Domain.Entities.Tasks.Task;

namespace Application.Common.Mapping
{
    public class TaskMapping : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Task, TaskDTO>().
                Map(dest => dest.Id, src => src.Id.Value);
            config.NewConfig<int, DeleteTaskCommand>().
                MapWith(src => new DeleteTaskCommand(src));
            config.NewConfig<int, GetTaskByIdQuery>().
                MapWith(src => new GetTaskByIdQuery(src));
        }
    }
}
