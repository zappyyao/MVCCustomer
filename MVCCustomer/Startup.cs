using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCustomer.Startup))]
namespace MVCCustomer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
