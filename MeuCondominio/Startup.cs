using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeuCondominio.Startup))]
namespace MeuCondominio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
