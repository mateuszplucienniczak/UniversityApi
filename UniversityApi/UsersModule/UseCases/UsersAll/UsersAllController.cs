using Microsoft.AspNetCore.Mvc;
using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.UsersAll;

[ApiController]
public class UsersAllController(AppDbContext context) : ControllerBase
{
    [HttpGet("api/users")]
    public ActionResult<UserDto> GetUserAll()
    {
        var result = new UsersAllQueryHandler(context).Handle(new UsersAllQuery());

        return Ok(result);
    }
}