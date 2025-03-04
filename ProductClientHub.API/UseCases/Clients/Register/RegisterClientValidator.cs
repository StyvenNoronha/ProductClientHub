using FluentValidation;
using ProductClientHub.Communication.Request;

namespace ProductClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientValidator : AbstractValidator<RequestClientJson>
    {
        public RegisterClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().WithMessage("o Nome não pode ser vazio");
            RuleFor(client => client.Email).EmailAddress().WithMessage("o Email não pode ser vazio");
        }
    }
}
