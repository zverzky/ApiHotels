using FluentValidation;
using System.Data;
namespace ApiHotels.Models.Requests.Validators


{
    public class RegisterUserRequestValidator : AbstractValidator<RegisterUserRequest>
    {
        public RegisterUserRequestValidator() 
        {
            RuleFor(model => model.Email).EmailAddress().WithMessage("Этот email не email");
            RuleFor(model => model.Password).MinimumLength(8);
            RuleFor(model => model.UserName).MaximumLength(50).MinimumLength(3);
        }
    }
}
