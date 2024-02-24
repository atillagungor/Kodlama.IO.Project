using AutoMapper;
using Entities.Concretes;
using Business.Dtos.Request.Course;
using Business.Dtos.Response.Course;
using Core.Paging;

namespace Business.Profiles;

public class CourseProfile : Profile
{
    public CourseProfile()
    {
        CreateMap<Course, CreateCourseRequest>().ReverseMap();
        CreateMap<Course, CreatedCourseResponse>().ReverseMap();

        CreateMap<Course, UpdateCourseRequest>().ReverseMap();
        CreateMap<Course, UpdatedCourseResponse>().ReverseMap();

        CreateMap<Course, DeleteCourseRequest>().ReverseMap();
        CreateMap<Course, DeletedCourseResponse>().ReverseMap();

        CreateMap<IPaginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();
        CreateMap<Course, GetListCourseResponse>().ReverseMap();
    }
}