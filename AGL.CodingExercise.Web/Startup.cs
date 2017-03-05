using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AGL.CodingExercise.Web.Startup))]
namespace AGL.CodingExercise.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
