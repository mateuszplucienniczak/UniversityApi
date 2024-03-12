using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.CreateUser;

public record CreateUserCommand(string Username, string Email, string Password) : ICommand;