using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRentalApp.Startup))]
namespace CarRentalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
