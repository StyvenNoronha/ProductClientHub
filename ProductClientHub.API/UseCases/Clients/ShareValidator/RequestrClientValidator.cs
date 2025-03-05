using FluentValidation;
using ProductClientHub.Communication.Request;

namespace ProductClientHub.API.UseCases.Clients.ShareValidator
{
    public class RequestrClientValidator : AbstractValidator<RequestClientJson>
    {
        public RequestrClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().WithMessage("o Nome não pode ser vazio");
            RuleFor(client => client.Email).EmailAddress().WithMessage("o Email não pode ser vazio");
        }
    }
}
