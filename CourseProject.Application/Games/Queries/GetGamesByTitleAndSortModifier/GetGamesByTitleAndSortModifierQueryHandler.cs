using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Enums;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Games.Queries.GetGamesByTitleAndSortModifier;

internal class GetGamesByTitleAndSortModifierQueryHandler : IQueryHandler<GetGamesByTitleAndSortModifierQuery, List<Game>>
{
    private readonly IGameRepository _gameRepository;

    public GetGamesByTitleAndSortModifierQueryHandler(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }

    public async Task<Result<List<Game>>> Handle(GetGamesByTitleAndSortModifierQuery request, CancellationToken cancellationToken)
    {
        string title = request.Title.Trim();
        var where = (Game x) => ((string)x.Title).StartsWith(request.Title);
        
        Func<Game, object> orderBy = request.SortingStrategy switch
        {
            SortGamesBy.Title => (Game x) => (string)x.Title,
            SortGamesBy.LowestPrice => (Game x) => (decimal)x.Price,
            SortGamesBy.HighestPrice => (Game x) => (decimal)x.Price,
            SortGamesBy.Date => (Game x) => (DateTime)x.CreationDate,
            SortGamesBy.DateDescending => (Game x) => (DateTime)x.CreationDate,
            _ => throw new NotImplementedException()
        };

        bool inAscendingOrder = request.SortingStrategy switch
        {
            SortGamesBy.Title => true,
            SortGamesBy.LowestPrice => true,
            SortGamesBy.HighestPrice => false,
            SortGamesBy.Date => true,
            SortGamesBy.DateDescending => false,
            _ => throw new NotImplementedException()
        };

        var games = await _gameRepository.GetByTitleAndSortModifier(title, where, orderBy, inAscendingOrder, (int)request.Skip, (int)request.Top, cancellationToken);

        return games;
    }
}
