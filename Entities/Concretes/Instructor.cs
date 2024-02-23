using Entities.Abstract;

namespace Entities.Concretes;

public class Instructor : Entity<Guid>
{
    public string FullName { get; set; }
}