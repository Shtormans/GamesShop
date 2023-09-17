using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Application.Comments.Commands.CreateCommand;

public sealed record CreateCommentCommand(string Text, UserId AuthorId, GameId GameId) : ICommand;
