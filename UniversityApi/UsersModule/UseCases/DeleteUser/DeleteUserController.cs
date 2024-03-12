using Microsoft.AspNetCore.Mvc;
using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.DeleteUser;

[ApiController]
public class DeleteUserController(AppDbContext context) : ControllerBase
{
    [HttpDelete("api/users/{userId:int}")]
    public ActionResult DeleteUser(int userId)
    {
        new DeleteUserCommandHandler(context).Handle(new DeleteUserCommand(userId));

        return Ok();
    }
}