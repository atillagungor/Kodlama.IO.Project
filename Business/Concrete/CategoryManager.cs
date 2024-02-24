using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.Category;
using Business.Dtos.Response.Category;
using Core.Paging;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    IMapper _mapper;
    public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
    }
    public async Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest)
    {
        await _categoryBusinessRules.AlreadyExists(createCategoryRequest.Name);
        Category cat = _mapper.Map<Category>(createCategoryRequest);
        Category createdCat = await _categoryDal.AddAsync(cat);

        CreatedCategoryResponse createdCatResponse = _mapper.Map<CreatedCategoryResponse>(createdCat);
        return createdCatResponse;
    }

    public async Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest)
    {
        Category cat = await _categoryBusinessRules.CheckIfExistsById(deleteCategoryRequest.Id);
        Category deletedCat = await _categoryDal.DeleteAsync(cat, true);

        DeletedCategoryResponse deletedCatResponse = _mapper.Map<DeletedCategoryResponse>(deletedCat);
        return deletedCatResponse;
    }

    public async Task<IPaginate<GetListCategoryResponse>> GetListAsync(PageRequest pageRequest)
    {
        var categories = await _categoryDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListCategoryResponse>>(categories);
    }

    public async Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest)
    {
        Category cat = await _categoryBusinessRules.CheckIfExistsById(updateCategoryRequest.Id);
        _mapper.Map(updateCategoryRequest, cat);
        Category updateDcat = await _categoryDal.UpdateAsync(cat);
        UpdatedCategoryResponse updateDcatResponse = _mapper.Map<UpdatedCategoryResponse>(updateDcat);
        return updateDcatResponse;
    }
}