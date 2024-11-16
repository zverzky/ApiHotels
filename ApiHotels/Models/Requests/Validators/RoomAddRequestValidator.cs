using FluentValidation;

namespace ApiHotels.Models.Requests.Validators
{
    public class RoomAddRequestValidator : AbstractValidator<RoomAddRequest>
    {
        public RoomAddRequestValidator() 
        {
            RuleFor(model => model.Id).NotEmpty(); 
            RuleFor(model => model.type).NotEmpty();
            RuleFor(model => model.price).GreaterThan(0).WithMessage("Кто ты воин?");
            RuleFor(model => model.HotelId).NotEmpty();
        }
    }
}
