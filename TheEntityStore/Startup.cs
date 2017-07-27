using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheEntityStore.Startup))]
namespace TheEntityStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
