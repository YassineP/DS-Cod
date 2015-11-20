using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(D_Sante.Startup))]
namespace D_Sante
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
