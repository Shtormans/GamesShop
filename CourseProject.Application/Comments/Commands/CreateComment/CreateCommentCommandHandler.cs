using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Abstractions;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Comment;

namespace CourseProject.Application.Comments.Commands.CreateCommand;

internal sealed class CreateCommentCommandHandler : ICommandHandler<CreateCommentCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly ICommentRepository _commentRepository;
    private readonly IGameRepository _gameRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCommentCommandHandler(
        IUserRepository userRepository, 
        ICommentRepository commentRepository, 
        IGameRepository gameRepository, 
        IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _commentRepository = commentRepository;
        _gameRepository = gameRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        var textResult = CommentText.Create(request.Text);
        if (textResult.IsFailure)
        {
            return Result.Failure(textResult.Error);
        }

        var user = await _userRepository.GetByIdAsync(request.AuthorId.Value, cancellationToken);
        if (user is null) 
        {
            return Result.Failure(DomainErrors.User.WrongId);
        }
        var game = await _gameRepository.GetByIdAsync(request.GameId.Value, cancellationToken);
        if (game is null)
        {
            return Result.Failure(DomainErrors.User.WrongId);
        }

        var comment = Comment.Create(
            request.AuthorId,
            textResult.Value,
            request.GameId
        );

        _commentRepository.Add(comment);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
