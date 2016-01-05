using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jos_jednom.Startup))]
namespace jos_jednom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
