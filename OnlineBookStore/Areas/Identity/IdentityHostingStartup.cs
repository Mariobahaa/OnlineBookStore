using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineBookStore.Data;

[assembly: HostingStartup(typeof(OnlineBookStore.Areas.Identity.IdentityHostingStartup))]
namespace OnlineBookStore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<OnlineBookStoreContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("OnlineBookStoreContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<OnlineBookStoreContext>();
            });
        }
    }
}