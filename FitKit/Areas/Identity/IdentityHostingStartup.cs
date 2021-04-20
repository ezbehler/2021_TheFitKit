using System;
using FitKit.Areas.Identity.Data;
using FitKit.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FitKit.Areas.Identity.IdentityHostingStartup))]
namespace FitKit.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FitKitDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FitKitDbContextConnection")));

                services.AddDefaultIdentity<FitKitUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FitKitDbContext>();
            });
        }
    }
}