namespace Business.Rule;

public class CategoryBusinessRules : BaseBusinessRules<Category>
{
    ICategoryDal _categoryDal;
    public CategoryBusinessRules(ICategoryDal categoryDal) : base(categoryDal)
    {
        _categoryDal = categoryDal;
    }
    public async Task AlreadyExists(string name)
    {
        var entity = await _categoryDal.GetAsync(c => c.Name == name);
        if (entity != null)
        {
            throw new BusinessException(BusinessMessages.CategoryAlreadyExists, BusinessTitles.AlreadyExistsError);
        }
    }
}