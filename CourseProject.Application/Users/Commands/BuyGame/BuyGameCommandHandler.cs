using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Abstractions;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Application.Users.Commands.BuyGame;

internal class BuyGameCommandHandler : ICommandHandler<BuyGameCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IGameRepository _gameRepository;
    private readonly ITransactionRepository _transactionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public BuyGameCommandHandler(IUserRepository userRepository, IGameRepository gameRepository, ITransactionRepository transactionRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _gameRepository = gameRepository;
        _transactionRepository = transactionRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(BuyGameCommand request, CancellationToken cancellationToken)
    {
        var payer = await _userRepository.GetByIdAsync(request.PayerId, cancellationToken);
        if (payer is null)
        {
            return Result.Failure(DomainErrors.User.WrongId);
        }

        var game = await _gameRepository.GetByIdAsync(request.GameId, cancellationToken);
        if (game is null)
        {
            return Result.Failure(DomainErrors.Game.WrongId);
        }

        var receiver = await _userRepository.GetByIdWithLibraryAsync(request.ReceiverId, cancellationToken);
        if (receiver is null)
        {
            return Result.Failure(DomainErrors.User.WrongId);
        }

        var gameAlreadyBought = receiver.Library.Any(g => g.Id == game.Id);
        if (gameAlreadyBought)
        {
            return Result.Failure(DomainErrors.User.GameAlreadyBought);
        }

        var userWithTracking = await _userRepository.GetByIdWithTrackingAsync(request.ReceiverId, cancellationToken);
        userWithTracking.BuyGame(game);

        var transaction = Transaction.Create(
            UserId.Create(request.PayerId).Value, 
            UserId.Create(request.ReceiverId).Value, 
            GameId.Create(request.GameId).Value, 
            request.Price.ConvertToUSD()
        );
        _transactionRepository.Add(transaction.Value);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}
