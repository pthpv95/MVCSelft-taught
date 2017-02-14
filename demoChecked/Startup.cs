using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demoChecked.Startup))]
namespace demoChecked
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
