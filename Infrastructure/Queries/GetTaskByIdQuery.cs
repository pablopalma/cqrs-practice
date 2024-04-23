﻿using CQRS.Practice.Application.DTOs;
using MediatR;

namespace CQRS.Practice.Infrastructure.Queries
{
    public record GetTaskByIdQuery(int id) : IRequest<TaskItemDto>;
}
