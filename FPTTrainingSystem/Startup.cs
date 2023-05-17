using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FPTTrainingSystem.Startup))]
namespace FPTTrainingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
