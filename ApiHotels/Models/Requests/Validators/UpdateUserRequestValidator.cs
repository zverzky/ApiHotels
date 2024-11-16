using FluentValidation;
namespace ApiHotels.Models.Requests.Validators

{
    public class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserRequestValidator()
        {
            RuleFor(model => model.LastName).MaximumLength(50).MinimumLength(3);
            RuleFor(model => model.Password).MinimumLength(8);
            RuleFor(model => model.UserName).MaximumLength(50).MinimumLength(3);
            RuleFor(model => model.PhoneNumber).Length(11);

        }
    }
}
