using Business.Dtos.Request.Course;
using Business.Dtos.Response.Course;
using Core.Paging;

namespace Business.Abstract;

public interface ICourseService
{
    Task<CreatedCourseResponse> AddAsync(CreateCourseRequest createCourseRequest);
    Task<IPaginate<GetListCourseResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedCourseResponse> DeleteAsync(DeleteCourseRequest deleteCourseRequest);
    Task<UpdatedCourseResponse> UpdateAsync(UpdateCourseRequest updateCourseRequest);
}