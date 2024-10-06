using CourseProject.Domain.Primitives;
using CourseProject.Domain.ValueObjects.User;
using Newtonsoft.Json;

namespace CourseProject.Domain.Entities;

public sealed class User : Entity
{
    private List<User> _friends;
    private List<Comment> _comments;
    private List<Game> _library;
    private List<Game> _createdGames;

    [Newtonsoft.Json.JsonConstructor]
    private User(Guid id)
        : base(id)
    {
    }

    [JsonProperty]
    public Username Username { get; private set; }
    [JsonProperty]
    public UserEmail Email { get; private set; }
    [JsonProperty] 
    public UserPassword Password { get; private set; }
    [JsonProperty]
    public UserFirstName? FirstName { get; private set; }
    [JsonProperty]
    public UserSecondName? SecondName { get; private set; }
    [JsonProperty]
    public UserProfilePicture ProfilePicture { get; private set; }
    [JsonProperty]
    public UserBirthday Birthday { get; private set; }
    public IReadOnlyList<User> Friends => _friends;
    public IReadOnlyList<Comment> Comments => _comments;
    public IReadOnlyList<Game> Library => _library;
    public IReadOnlyList<Game> CreatedGames => _createdGames;


    public static User Create(
                Username username,
                UserEmail email,
                UserPassword password,
                UserBirthday birthday,
                UserProfilePicture userImage,
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
            ProfilePicture = userImage,
            FirstName = firstName,
            SecondName = secondName
        };

        return user;
    }

    public void AddFriend(User friend)
    {
        if (_friends is null)
        {
            _friends = new();
        }

        _friends.Add(friend);
    }

    public void BuyGame(Game game)
    {
        if (_library is null)
        {
            _library = new();
        }

        _library.Add(game);
    }
}
