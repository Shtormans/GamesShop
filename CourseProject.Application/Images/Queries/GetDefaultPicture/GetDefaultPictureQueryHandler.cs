using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using System.Drawing;

namespace CourseProject.Application.Images.Queries.GetDefaultPicture;

internal class GetDefaultPictureQueryHandler : IQueryHandler<GetDefaultPictureQuery, Image>
{
    private readonly ICashRepository _cashRepository;

    public GetDefaultPictureQueryHandler(ICashRepository cashRepository)
    {
        _cashRepository = cashRepository;
    }

    public async Task<Result<Image>> Handle(GetDefaultPictureQuery request, CancellationToken cancellationToken)
    {
        var image = await _cashRepository.GetDefaultPicture();

        return image;
    }
}
