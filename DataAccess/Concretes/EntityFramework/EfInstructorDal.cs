using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfInstructorDal : EfRepositoryBase<Instructor, Guid, KodlamaIOContext>, IInstructorDal
{
    public EfInstructorDal(KodlamaIOContext context) : base(context)
    {
    }
}