using Entities.Concretes;

namespace DataAccess.Abstract;

public interface ICategoryDal : IAsyncRepository<Category, Guid>, IRepository<Category, Guid>
{
}