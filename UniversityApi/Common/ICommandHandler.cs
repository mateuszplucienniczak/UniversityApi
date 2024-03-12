namespace UniversityApi.Common;

public interface ICommandHandler<in TCommand, out TResult>
{
    public TResult Handle(TCommand command);
}