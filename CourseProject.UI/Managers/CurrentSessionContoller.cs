using CourseProject.Domain.Entities;
using CourseProject.UI.Models;

namespace CourseProject.UI.Managers;

internal sealed class CurrentSessionContoller
{
    private static CurrentSessionContoller? _instance;
    private Session _currentSession;

    public CurrentSessionContoller()
    {
        _instance = this;
    }

    public static CurrentSessionContoller Instance
    {
        get
        {
            if (_instance is null)
            {
                throw new NotImplementedException();
            }

            return _instance;
        }
    }

    public static Session CurrentSession
    {
        get
        {
            return Instance._currentSession;
        }
    }

    public static void SetNewSession(User currentUser)
    {
        Instance._currentSession = new Session(currentUser);
    }
}
