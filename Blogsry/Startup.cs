using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blogsry.Startup))]
namespace Blogsry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
