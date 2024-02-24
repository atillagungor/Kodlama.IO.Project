using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.Course;
using Business.Dtos.Response.Course;
using Core.Paging;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    IMapper _mapper;
    ICourseDal _courseDal;
    public CourseManager(IMapper mapper, ICourseDal courseDal)
    {
        _mapper = mapper;
        _courseDal = courseDal;
    }
    public async Task<CreatedCourseResponse> AddAsync(CreateCourseRequest createCourseRequest)
    {
        await _courseBusinessRules.CheckCategoryIfExists(createCourseRequest.CategoryId);
        Course course = _mapper.Map<Course>(createCourseRequest);
        Course addedCourse = await _courseDal.AddAsync(course);
        return _mapper.Map<CreatedCourseResponse>(addedCourse);
    }

    public async Task<DeletedCourseResponse> DeleteAsync(DeleteCourseRequest deleteCourseRequest)
    {
        Course course = await _courseBusinessRules.CheckIfExistsById(deleteCourseRequest.Id);
        Course deletedCourse = await _courseDal.DeleteAsync(course);
        return _mapper.Map<DeletedCourseResponse>(deletedCourse);
    }

    public async Task<IPaginate<GetListCourseResponse>> GetListAsync(PageRequest pageRequest)
    {
        var courses = await _courseDal.GetListAsync(
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize,
            include: c => c.Include(c => c.Category).Include(c => c.Like)
            );
        return _mapper.Map<Paginate<GetListCourseResponse>>(courses);
    }

    public async Task<UpdatedCourseResponse> UpdateAsync(UpdateCourseRequest updateCourseRequest)
    {
        await _courseBusinessRules.CheckCategoryIfExists(updateCourseRequest.CategoryId);
        Course course = await _courseBusinessRules.CheckIfExistsById(updateCourseRequest.Id);
        _mapper.Map(updateCourseRequest, course);
        Course updatedCourse = await _courseDal.UpdateAsync(course);
        return _mapper.Map<UpdatedCourseResponse>(updatedCourse);
    }
}