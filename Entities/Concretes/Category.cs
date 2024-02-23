using Entities.Abstract;

namespace Entities.Concretes;

public class Category : Entity<Guid>
{
    public string Name { get; set; }
    public ICollection<Course> courses { get; set; }
}