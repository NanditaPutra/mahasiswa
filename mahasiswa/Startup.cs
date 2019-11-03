using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mahasiswa.Startup))]
namespace mahasiswa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
