using Entities.Abstract;

namespace Entities.Concretes;

public class Course : Entity<Guid>
{
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public string ImageUrl { get; set; }
    public Category Category { get; set; }
    public Instructor Instructor { get; set; }
}