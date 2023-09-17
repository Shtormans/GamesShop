using CourseProject.Domain.Shared;
using MediatR;

namespace CourseProject.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
