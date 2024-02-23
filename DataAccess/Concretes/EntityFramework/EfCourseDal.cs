using Core.Repositories.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCourseDal : EfRepositoryBase<Course, Guid, KodlamaIOContext>, ICourseDal
{
    public EfCourseDal(KodlamaIOContext context) : base(context)
    {
    }
}