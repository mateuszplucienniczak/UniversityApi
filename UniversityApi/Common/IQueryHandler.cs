namespace UniversityApi.Common;

public interface IQueryHandler<in TQuery, out TResult>
{
    public TResult Handle(TQuery query);
}