namespace Business.Dtos.Request.Course;

public class UpdateCourseRequest
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
}