using CourseProject.Domain.Entities;
using CourseProject.Domain.Enums;
using System.Resources;

namespace CourseProject.UI.Models;

internal class ChangeSessionModel
{
    public User? User { get; set; }
    public ResourceManager? Language { get; set; }
    public CurrencyType? CurrencyType { get; set; }
}
