﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Password_Keep.Areas.Identity.Data;
using Password_Keep.Data;

[assembly: HostingStartup(typeof(Password_Keep.Areas.Identity.IdentityHostingStartup))]
namespace Password_Keep.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Password_KeepDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Password_KeepDbContextConnection")));

                services.AddDefaultIdentity<Password_KeepUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<Password_KeepDbContext>();
            });
        }
    }
}