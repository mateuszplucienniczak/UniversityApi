using UniversityApi.Common;

namespace UniversityApi.UsersModule.UseCases.UserById;

public record UserByIdQuery(int UserId) : IQuery;