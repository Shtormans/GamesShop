using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using System.Drawing;

namespace CourseProject.Application.Images.Queries.GetGameIcons;

internal class GetGameIconsQueryHandler : IQueryHandler<GetGameIconsQuery, List<Image>>
{
    private readonly ICashRepository _cashRepository;

    public GetGameIconsQueryHandler(ICashRepository cashRepository)
    {
        _cashRepository = cashRepository;
    }

    public async Task<Result<List<Image>>> Handle(GetGameIconsQuery request, CancellationToken cancellationToken)
    {
        var images = new List<Image>(request.GameIcons.Count);

        foreach (var gameIcon in request.GameIcons)
        {
            string pictureName = gameIcon.Id.ToString();

            var image = await _cashRepository.GetGameIcon(pictureName).ConfigureAwait(false);

            images.Add(image);
        }

        return images;
    }
}
