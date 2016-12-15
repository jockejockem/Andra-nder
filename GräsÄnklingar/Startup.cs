using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GräsÄnklingar.Startup))]
namespace GräsÄnklingar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
