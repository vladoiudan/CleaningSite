using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DAV.UniverseCleaning.Startup))]
namespace DAV.UniverseCleaning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
