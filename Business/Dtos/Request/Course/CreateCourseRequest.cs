namespace Business.Dtos.Request.Course;

public class CreateCourseRequest
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
}