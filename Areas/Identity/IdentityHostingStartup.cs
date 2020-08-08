using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(SynergyWebApp.Areas.Identity.IdentityHostingStartup))]
namespace SynergyWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}