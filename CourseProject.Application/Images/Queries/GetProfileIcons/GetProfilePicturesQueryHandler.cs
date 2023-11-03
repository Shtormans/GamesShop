using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using System.Drawing;

namespace CourseProject.Application.Images.Queries.GetGameIcons;

internal class GetProfilePicturesQueryHandler : IQueryHandler<GetProfilePicturesQuery, List<Image>>
{
    private readonly ICashRepository _cashRepository;

    public GetProfilePicturesQueryHandler(ICashRepository cashRepository)
    {
        _cashRepository = cashRepository;
    }

    public async Task<Result<List<Image>>> Handle(GetProfilePicturesQuery request, CancellationToken cancellationToken)
    {
        var images = new List<Image>(request.ProfilePictures.Count);

        foreach (var profilePicture in request.ProfilePictures)
        {
            string pictureName = profilePicture.Id.ToString();

            var image = await _cashRepository.GetProfilePicture(pictureName).ConfigureAwait(false);

            images.Add(image);
        }

        return images;
    }
}
