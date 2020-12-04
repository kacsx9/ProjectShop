using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjektSklep.Data;

[assembly: HostingStartup(typeof(ProjektSklep.Areas.Identity.IdentityHostingStartup))]
namespace ProjektSklep.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProjektSklepContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProjektSklepContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ProjektSklepContext>();
            });
        }
    }
}