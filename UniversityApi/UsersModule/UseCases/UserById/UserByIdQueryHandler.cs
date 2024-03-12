using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.UserById;

public class UserByIdQueryHandler(AppDbContext context) : IQueryHandler<UserByIdQuery, UserDto?>
{
    public UserDto? Handle(UserByIdQuery query)
    {
        var user = context.Users.FirstOrDefault(u => u.UserId == query.UserId);

        if (user is null) return null;

        return new UserDto(user.Username, user.Email);
    }
}