using Entities.Concretes;

namespace DataAccess.Abstract;

public interface ICourseDal : IAsyncRepository<Course, Guid>, IRepository<Course, Guid>
{
}