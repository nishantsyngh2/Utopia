using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Utopia.Startup))]
namespace Utopia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
