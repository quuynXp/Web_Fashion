using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Web_Fashion.StartupOwin))]

namespace Web_Fashion
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
