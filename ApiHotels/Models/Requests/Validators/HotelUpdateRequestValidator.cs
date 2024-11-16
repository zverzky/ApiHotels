using FluentValidation;

namespace ApiHotels.Models.Requests.Validators
{
    public class HotelUpdateRequestValidator : AbstractValidator<HotelUpdateRequest>
    {
        public HotelUpdateRequestValidator()
        {
            RuleFor(model => model.Name).MaximumLength(15).MinimumLength(2);
            RuleFor(model => model.Adress).MaximumLength(50).MinimumLength(10);
        }
    }
}
