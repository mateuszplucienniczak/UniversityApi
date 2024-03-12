using Microsoft.AspNetCore.Mvc;
using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.CreateUser;

[ApiController]
public class CreateUserController(AppDbContext context) : ControllerBase
{
    [HttpPost("api/users")]
    public ActionResult<int> CreateUser(CreateUserCommand command)
    {
        var userId = new CreateUserCommandHandler(context).Handle(command);

        return CreatedAtAction(null, userId);
    }
}