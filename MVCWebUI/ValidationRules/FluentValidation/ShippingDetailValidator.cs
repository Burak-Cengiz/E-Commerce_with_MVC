using FluentValidation;
using MVCWebUI.Models;

namespace MVCWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(expression: s => s.FirstName).NotEmpty();
            RuleFor(expression: s => s.FirstName).MinimumLength(2);
            RuleFor(expression: s => s.LastName).NotEmpty();
            RuleFor(expression: s => s.Address).NotEmpty();

            RuleFor(expression: s => s.City).NotEmpty().When(predicate: s => s.Age < 10);
            RuleFor(expression: s => s.FirstName).Must(StartWithA);

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
