using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;
using DataAccess.Abstract;
using DataAccess.Concretes.EntityFramework;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<KodlamaIOContext>(options => options.UseSqlServer(configuration.GetConnectionString("KodlamaIo")));

        services.AddScoped<ICategoryDal, EfCategoryDal>();
        services.AddScoped<ICourseDal, EfCourseDal>();
        services.AddScoped<IInstructorDal, EfInstructorDal>();

        return services;
    }
}