using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.DeleteUser;

public record DeleteUserCommand(int UserId) : ICommand;