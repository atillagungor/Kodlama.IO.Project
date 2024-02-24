using Business.Dtos.Request.Category;
using Business.Dtos.Response.Category;
using Core.Paging;

namespace Business.Abstract;

public interface ICategoryService
{
    Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest);
    Task<IPaginate<GetListCategoryResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest);
    Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest);
}