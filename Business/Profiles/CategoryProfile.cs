using AutoMapper;
using Entities.Concretes;
using Business.Dtos.Request.Category;
using Business.Dtos.Response.Category;
using Core.Paging;

namespace Business.Profiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CreateCategoryRequest>().ReverseMap();
        CreateMap<Category, CreatedCategoryResponse>().ReverseMap();

        CreateMap<Category, UpdateCategoryRequest>().ReverseMap();
        CreateMap<Category, UpdatedCategoryResponse>().ReverseMap();

        CreateMap<Category, DeleteCategoryRequest>().ReverseMap();
        CreateMap<Category, DeletedCategoryResponse>().ReverseMap();

        CreateMap<IPaginate<Category>, Paginate<GetListCategoryResponse>>().ReverseMap();
        CreateMap<Category, GetListCategoryResponse>().ReverseMap();
    }
}