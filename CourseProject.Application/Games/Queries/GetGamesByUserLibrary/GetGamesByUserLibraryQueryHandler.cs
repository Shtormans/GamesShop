using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Games.Queries.GetGamesByUserLibrary;

internal class GetGamesByUserLibraryQueryHandler : IQueryHandler<GetGamesByUserLibraryQuery, List<Game>>
{
    private readonly IUserRepository _userRepository;

    public GetGamesByUserLibraryQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<List<Game>>> Handle(GetGamesByUserLibraryQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdWithLibraryAsync(request.UserId, cancellationToken);
        if (user is null)
        {
            return Result.Failure<List<Game>>(DomainErrors.User.WrongId);
        }

        return user.Library.ToList();
    }
}
