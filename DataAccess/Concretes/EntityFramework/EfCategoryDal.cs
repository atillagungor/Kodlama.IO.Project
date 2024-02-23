using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCategoryDal : EfRepositoryBase<Category, Guid, KodlamaIOContext>, ICategoryDal
{
    public EfCategoryDal(KodlamaIOContext context) : base(context)
    {
    }
}