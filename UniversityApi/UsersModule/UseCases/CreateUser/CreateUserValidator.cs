using FluentValidation;

namespace UniversityApi.UsersModule.UseCases.CreateUser;

public class CreateUserValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserValidator()
    {
        RuleFor(u => u.Username)
            .MinimumLength(3)
            .MaximumLength(20);

        RuleFor(u => u.Email)
            .EmailAddress();

        RuleFor(u => u.Password)
            .MinimumLength(6)
            .MaximumLength(20);
    }
}