using CourseProject.Domain.Entities;
using CourseProject.Domain.Enums;
using CourseProject.UI.Models;
using System.Reflection;
using System.Resources;

namespace CourseProject.UI.Managers;

internal sealed class CurrentSessionController
{
    private static CurrentSessionController? _instance;
    private Session _currentSession;

    public CurrentSessionController()
    {
        _instance = this;
    }

    public static CurrentSessionController Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new CurrentSessionController();
            }

            return _instance;
        }
    }

    public static Session Session
    {
        get
        {
            return Instance._currentSession;
        }
    }

    public static void SetNewSession(ChangeSessionModel sessionModel)
    {
        sessionModel.User ??= Session?.User;
        sessionModel.Language ??= Session?.Language;
        sessionModel.CurrencyType ??= Session?.CurrencyType;

        Instance._currentSession = new Session(sessionModel.User, sessionModel.Language, (CurrencyType)sessionModel.CurrencyType);
    }
}
