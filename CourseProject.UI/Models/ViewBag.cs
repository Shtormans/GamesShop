using System.Dynamic;

namespace CourseProject.UI.Models;

public class ViewBag : DynamicObject
{
    private readonly Dictionary<string, object> _members = new();

    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        if (value is not null)
        {
            _members[binder.Name] = value;
            return true;
        }

        return false;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        result = null;

        if (_members.ContainsKey(binder.Name))
        {
            result = _members[binder.Name];
            return true;
        }

        return false;
    }
}
