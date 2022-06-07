using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExceptionFilterExample.Startup))]
namespace ExceptionFilterExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
