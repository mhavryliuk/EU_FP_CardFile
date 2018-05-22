using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CardFile.Startup))]
namespace CardFile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
