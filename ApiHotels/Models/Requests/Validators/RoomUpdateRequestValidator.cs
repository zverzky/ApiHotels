using FluentValidation;

namespace ApiHotels.Models.Requests.Validators
{
    public class RoomUpdateRequestValidator : AbstractValidator<RoomUpdateRequest>
    {
        public RoomUpdateRequestValidator() 
        {
            RuleFor(model => model.type).NotEmpty();
            RuleFor(model => model.price).GreaterThan(0).WithMessage("Кто ты воин?");
        }
    }
}
