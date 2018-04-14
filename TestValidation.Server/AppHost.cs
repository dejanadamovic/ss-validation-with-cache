using Funq;
using ServiceStack;
using ServiceStack.Validation;

namespace TestValidation.Server
{
    public class AppHost : AppSelfHostBase
    {
        public AppHost()
            : base("TestValidation.Server", typeof(HelloService).Assembly) { }
        
        public override void Configure(Container container)
        {
            this.Plugins.Add(new ValidationFeature());
            container.RegisterValidators(typeof(HelloValidator).Assembly);
        }
    }
}
