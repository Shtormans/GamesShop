using CourseProject.Application.Games.Queries.GetGamesByTitleAndSortModifier;
using CourseProject.Application.Images.Queries.GetGameIcons;
using CourseProject.Domain.Enums;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Models;
using MediatR;

namespace CourseProject.UI.Controllers;

internal class StoreController : BaseController
{
    private const int TopAmount = 9;

    public StoreController(ISender sender) 
        : base(sender)
    {
    }

    public async Task<List<GameModelWithImage>> GetNextGames(string title, SortGamesBy sortGamesBy, int skip, List<GameGenre> genres)
    {
        var storeQuery = new GetGamesByTitleAndSortModifierQuery(title, sortGamesBy, (uint)skip, TopAmount, genres);
        var games = await Sender.Send(storeQuery);

        var gameIconsQuery = new GetGameIconsQuery(games.Value.Select(game => game.Image).ToList());
        var gameIcons = await Sender.Send(gameIconsQuery);

        var result = new List<GameModelWithImage>(games.Value.Count);
        for (int i = 0; i < games.Value.Count; i++)
        {
            result.Add(new GameModelWithImage()
            {
                Game = games.Value[i],
                Icon = gameIcons.Value[i]
            });
        }

        return result;
    }
}
