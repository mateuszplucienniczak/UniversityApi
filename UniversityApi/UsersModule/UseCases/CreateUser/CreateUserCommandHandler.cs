using UniversityApi.Common;
using UniversityApi.UsersModule.Domain;

namespace UniversityApi.UsersModule.UseCases.CreateUser;

public class CreateUserCommandHandler(AppDbContext context) : ICommandHandler<CreateUserCommand, int>
{
    public int Handle(CreateUserCommand command)
    {
        if (context.Users.Any(u => u.Username == command.Username))
            throw new Exception($"user with username {command.Username} already exists");

        var user = new User
        {
            Username = command.Username,
            Email = command.Email,
            Password = command.Password
        };

        context.Users.Add(user);
        context.SaveChanges();

        return user.UserId;
    }
}