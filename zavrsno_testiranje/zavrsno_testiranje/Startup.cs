using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zavrsno_testiranje.Startup))]
namespace zavrsno_testiranje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
