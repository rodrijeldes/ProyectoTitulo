using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_HojaDeTareas.Startup))]
namespace MVC_HojaDeTareas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
