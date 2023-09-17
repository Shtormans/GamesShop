using CourseProject.Domain.Enums;
using CourseProject.Domain.Primitives;
using CourseProject.Domain.ValueObjects.Identificators;
using CourseProject.Domain.ValueObjects.User;

namespace CourseProject.Domain.Entities;

public sealed class User : Entity
{
    private List<User> _friends;
    private List<Comment> _comments;
    private List<Game> _games;

    public User(Guid id)
        : base(id)
    {
    }

    public Username Username { get; private set; }
    public UserEmail Email { get; private set; }
    public UserPassword Password { get; private set; }
    public UserFirstName? FirstName { get; private set; }
    public UserSecondName? SecondName { get; private set; }
    public UserImage Image { get; private set; }
    public UserBirthday Birthday { get; private set; }
    public IReadOnlyList<User> Friends => _friends;
    public IReadOnlyList<Comment> Comments => _comments;
    public IReadOnlyList<Game> Games => _games;
    public Role Role { get; private set; }


    public static User Create(
                Username username,
                UserEmail email,
                UserPassword password,
                UserBirthday birthday,
                Role role,
                UserFirstName? firstName = null,
                UserSecondName? secondName = null)
    {
        Guid id = Guid.NewGuid();

        var user = new User(id)
        {
            Username = username,
            Email = email,
            Password = password,
            Birthday = birthday, 
            Role = role,
            FirstName = firstName,
            SecondName = secondName
        };

        return user;
    }
}
