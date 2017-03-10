using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetParameterInCustomAttributes.Startup))]
namespace GetParameterInCustomAttributes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
