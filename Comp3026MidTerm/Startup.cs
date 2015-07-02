using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comp3026MidTerm.Startup))]
namespace Comp3026MidTerm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
