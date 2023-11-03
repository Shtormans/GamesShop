using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Application.Images.Queries.GetGameIcons;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using System.Drawing;

namespace CourseProject.Application.Images.Queries.GetGameIcon;

internal class GetGameIconsQueryHandler : IQueryHandler<GetGameIconQuery, Image>
{
    private readonly ICashRepository _cashRepository;

    public GetGameIconsQueryHandler(ICashRepository cashRepository)
    {
        _cashRepository = cashRepository;
    }

    public async Task<Result<Image>> Handle(GetGameIconQuery request, CancellationToken cancellationToken)
    {
        string pictureName = request.GameIcon.Id.ToString();

        var image = await _cashRepository.GetGameIcon(pictureName).ConfigureAwait(false);

        return image;
    }
}
