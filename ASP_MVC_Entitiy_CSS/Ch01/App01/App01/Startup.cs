using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App01.Startup))]
namespace App01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
