using Business.Abstract;

namespace Business.Rule;

public class CourseBusinessRules : BaseBusinessRules<Course>
{
    ICourseDal _courseDal;
    ICategoryService _categoryService;
    public CourseBusinessRules(ICourseDal courseDal, ICategoryService categoryService) : base(courseDal)
    {
        _courseDal = courseDal;
        _categoryService = categoryService;
    }
    public async Task CheckCategoryIfExists(Guid categoryId)
    {
        GetCategoryResponse category = await _categoryService.GetByIdAsync(categoryId);
        if (category == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }
}