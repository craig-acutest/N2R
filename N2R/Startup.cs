using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(N2R.Startup))]
namespace N2R
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
