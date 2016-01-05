using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pokusaj_slanja.Startup))]
namespace pokusaj_slanja
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
