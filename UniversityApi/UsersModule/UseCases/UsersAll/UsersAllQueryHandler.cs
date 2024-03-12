using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.UsersAll;

public class UsersAllQueryHandler(AppDbContext context) : IQueryHandler<UsersAllQuery, IList<UserDto>>
{
    public IList<UserDto> Handle(UsersAllQuery query)
    {
        return context.Users.Select(u => new UserDto(u.Username, u.Email)).ToList();
    }
}