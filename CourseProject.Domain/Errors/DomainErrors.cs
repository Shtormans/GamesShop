using CourseProject.Domain.Shared;

namespace CourseProject.Domain.Errors;

public static class DomainErrors
{
    public static class User
    {
        public static readonly Error WrongId = new Error(
            "User.WrongId",
            $"Such user doesn't exist.");

        public static Error AlreadyExist(string email) => new Error(
                "User.AlreadyExist",
                $"User with email '{email}' already exist.");

        public static Error WrongEmail(string email) => new Error(
            "User.WrongEmail",
            $"User with email '{email}' does not exist.");

        public static Error WrongPassword(string email) => new Error(
            "User.WrongPassword",
            $"Wrong password for user with email '{email}'.");
    }

    public static class Game
    {
        public static readonly Error WrongId = new Error(
            "Game.WrongId",
            $"Such game doesn't exist.");
    }

    public static class Price
    {
        public static readonly Error IncorrectPrice = new Error(
            "Price.IncorrectPrice",
            $"Price is incorrect.");
    }
}
