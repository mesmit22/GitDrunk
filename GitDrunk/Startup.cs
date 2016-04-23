using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitDrunk.Startup))]
namespace GitDrunk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
