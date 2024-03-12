using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.DeleteUser;

public class DeleteUserCommandHandler(AppDbContext context) : ICommandHandler<DeleteUserCommand, bool>
{
    public bool Handle(DeleteUserCommand command)
    {
        var user = context.Users.FirstOrDefault(u => u.UserId == command.UserId);

        if (user is null) return false;

        context.Users.Remove(user);
        context.SaveChanges();

        return true;
    }
}