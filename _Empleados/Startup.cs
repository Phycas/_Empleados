using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_Empleados.Startup))]
namespace _Empleados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
