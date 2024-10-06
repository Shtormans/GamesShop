using CourseProject.Domain.Entities;
using CourseProject.Domain.Enums;
using System.Resources;

namespace CourseProject.UI.Models;

internal class Session
{
	public Session(User user, ResourceManager language, CurrencyType currencyType)
	{
		User = user;
		Language = language;
		CurrencyType = currencyType;
	}

    public User User { get; private set; }
	public ResourceManager Language { get; private set; }
	public CurrencyType CurrencyType { get; private set; }
}
