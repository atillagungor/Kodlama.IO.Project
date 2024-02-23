using Core.Abstract;
using Core.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstract;

public interface IInstructorDal : IAsyncRepository<Instructor, Guid>, IRepository<Instructor, Guid>
{
}