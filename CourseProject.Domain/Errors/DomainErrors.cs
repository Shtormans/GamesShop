using CourseProject.Domain.Shared;

namespace CourseProject.Domain.Errors;

public static class DomainErrors
{
    public static class User
    {
        public static readonly Error WrongId = new Error(
            "User.WrongId",
            $"Such user doesn't exist.");

        public static Error EmailAlreadyExist(string email) => new Error(
                "User.EmailAlreadyExist",
                $"User with email '{email}' already exist.");

        public static Error UsernameAlreadyExist(string username) => new Error(
                "User.UsernameAlreadyExist",
                $"User with username '{username}' already exist.");

        public static Error WrongEmail(string email) => new Error(
            "User.WrongEmail",
            $"User with email '{email}' does not exist.");

        public static Error WrongEmailOrUsername(string emailOrUsername) => new Error(
            "User.WrongEmailOrUsername",
            $"User with email or username '{emailOrUsername}' does not exist.");

        public static readonly Error WrongPassword = new Error(
            "User.WrongPassword",
            $"Wrong password.");

        public static readonly Error NoCahedAccount = new Error(
            "User.NoCahedAccount",
            "There is no cashed account saved.");
    }

    public static class Game
    {
        public static readonly Error WrongId = new Error(
            "Game.WrongId",
            $"Such game doesn't exist.");

        public static Error TitleAlreadyExist(string title) => new Error(
            "Game.TitleAlreadyExist",
            $"Game with title {title} already exist.");
    }

    public static class Price
    {
        public static readonly Error IncorrectPrice = new Error(
            "Price.IncorrectPrice",
            $"Price is incorrect.");
    }
}
