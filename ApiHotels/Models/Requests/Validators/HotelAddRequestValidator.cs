using FluentValidation;

namespace ApiHotels.Models.Requests.Validators
{
    public class HotelAddRequestValidator : AbstractValidator<HotelAddRequest>
    {
        public HotelAddRequestValidator()
        {
            RuleFor(model => model.Id).NotEmpty();
            RuleFor(model => model.Name).MaximumLength(15).MinimumLength(2);
            RuleFor(model => model.Adress).MaximumLength(50).MinimumLength(10);
        }
    }
}
