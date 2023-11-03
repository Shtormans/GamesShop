using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using System.Drawing;

namespace CourseProject.Application.Images.Queries;

internal class GetProfilePictureQueryHandler : IQueryHandler<GetProfilePictureQuery, Image>
{
    private readonly ICashRepository _cashRepository;

    public GetProfilePictureQueryHandler(ICashRepository cashRepository)
    {
        _cashRepository = cashRepository;
    }

    public async Task<Result<Image>> Handle(GetProfilePictureQuery request, CancellationToken cancellationToken)
    {
        string pictureName = request.ProfilePicture.Id.ToString();

        var image = await _cashRepository.GetProfilePicture(pictureName).ConfigureAwait(false);

        return image;
    }
}
