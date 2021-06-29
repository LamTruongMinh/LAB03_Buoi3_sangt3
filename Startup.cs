using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB03_1.Startup))]
namespace LAB03_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
