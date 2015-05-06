using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CILab.Startup))]
namespace CILab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
