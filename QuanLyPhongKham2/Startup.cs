using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyPhongKham2.Startup))]
namespace QuanLyPhongKham2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
