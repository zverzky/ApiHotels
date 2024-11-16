using FluentValidation;

namespace ApiHotels.Models.Requests.Validators
{
    public class BookingRequestValidator : AbstractValidator<BookingRequest>
    {
        public BookingRequestValidator() 
        {
            RuleFor(model => model.Id).NotEmpty();
            RuleFor(model => model.StartTime).NotEmpty();
            RuleFor(model => model.EndTime).NotEmpty();
            RuleFor(model => model.HotelId).NotEmpty();
        }
    }
}
