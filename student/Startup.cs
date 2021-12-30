using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(student.Startup))]
namespace student
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
