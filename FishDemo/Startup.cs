using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FishDemo.Startup))]
namespace FishDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
