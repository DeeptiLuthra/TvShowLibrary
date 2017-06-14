using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TvShowsLibrary.Startup))]
namespace TvShowsLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
