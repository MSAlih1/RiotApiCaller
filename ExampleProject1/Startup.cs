using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleProject1.Startup))]
namespace ExampleProject1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
