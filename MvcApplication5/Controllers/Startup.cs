using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MvcApplication5.Controllers.Startup))]
namespace MvcApplication5.Controllers
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
