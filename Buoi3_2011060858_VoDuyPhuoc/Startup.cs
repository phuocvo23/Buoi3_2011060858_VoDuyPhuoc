using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buoi3_2011060858_VoDuyPhuoc.Startup))]
namespace Buoi3_2011060858_VoDuyPhuoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
