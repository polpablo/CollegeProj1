using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRentals.Startup))]
namespace CarRentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
