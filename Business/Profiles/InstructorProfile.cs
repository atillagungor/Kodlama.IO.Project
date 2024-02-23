using AutoMapper;
using Business.Dtos.Request.Instructor;
using Business.Dtos.Response.Instructor;

namespace Business.Profiles;

public class InstructorProfile : Profile
{
    public InstructorProfile()
    {
        CreateMap<Instructor,CreateInstructorRequest>().ReverseMap();
        CreateMap<Instructor,CreatedInstructorResponse>().ReverseMap();

        CreateMap<Instructor, UpdateInstructorRequest>().ReverseMap();
        CreateMap<Instructor, UpdatedInstructorResponse>().ReverseMap();

        CreateMap<Instructor, DeleteInstructorRequest>().ReverseMap();
        CreateMap<Instructor, DeletedInstructorResponse>().ReverseMap();

        CreateMap<IPaginate<Instructor>, Paginate<GetListInstructorResponse>>().ReverseMap();
        CreateMap<Instructor, GetListInstructorResponse>().ReverseMap();
    }
}