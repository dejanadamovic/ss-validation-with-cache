using ServiceStack;
using ServiceStack.FluentValidation;

namespace TestValidation.Server
{
    public class HelloValidator : AbstractValidator<Hello>
    {
        public HelloValidator()
        {
            RuleSet(ApplyTo.Post, () =>
            {
                RuleFor(x => x.Name).NotEmpty();
            });
        }
    }
}
