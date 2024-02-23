namespace Core.Abstract;

public interface IQuery<T>
{
    IQueryable<T> Query();
}