using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupingDataInTable.Startup))]
namespace GroupingDataInTable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
