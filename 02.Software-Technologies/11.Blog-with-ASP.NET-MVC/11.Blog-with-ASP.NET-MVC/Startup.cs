using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_11.Blog_with_ASP.NET_MVC.Startup))]
namespace _11.Blog_with_ASP.NET_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
