using Microsoft.AspNetCore.Mvc;
using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.UserById;

[ApiController]
public class UserByIdController(AppDbContext context) : ControllerBase
{
    [HttpGet("api/users/{userId:int}")]
    public ActionResult<UserDto> GetUserById(int userId)
    {
        var result = new UserByIdQueryHandler(context).Handle(new UserByIdQuery(userId));

        return result is not null ? Ok(result) : NotFound();
    }
}