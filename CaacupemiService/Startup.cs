using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CaacupemiService.Startup))]

namespace CaacupemiService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}