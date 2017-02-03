using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionScolarite.Startup))]
namespace GestionScolarite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
