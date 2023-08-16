using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tasks.Commands.Delete
{
    public record DeleteTaskCommand
    (
        int Id
        ): IRequest;
}
