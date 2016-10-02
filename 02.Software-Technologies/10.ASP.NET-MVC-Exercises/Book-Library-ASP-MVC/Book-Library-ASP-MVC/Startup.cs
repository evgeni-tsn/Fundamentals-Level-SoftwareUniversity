using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Book_Library_ASP_MVC.Startup))]
namespace Book_Library_ASP_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
