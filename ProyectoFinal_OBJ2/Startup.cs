using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ProyectoFinal_OBJ2.StartupOwin))]

namespace ProyectoFinal_OBJ2
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
