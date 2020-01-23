using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using JTCM.MVC.Web.Data;
using JTCM.MVC.Web.Models;
using JTCM.MVC.Web.Services;
using AutoMapper;
using JTCM.DAL;
using JTCM.DAL.DBModel;
using JTMC.Services.Interfaces;
using JTCM.Services;
using JTCM.DAL.Interfaces;
using JTCM.DAL.Repositories;

namespace JTCM.MVC.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var localConnection = @"Server=.;Database=JTCM;User ID=sa;Password=Admin@123+;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddMvc();

            // AutoMapper with 2 profieles
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new NormalProfile());
                mc.AddProfile(new UpdateProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //services.AddAutoMapper( typeof(UpdateProfile));


            //DB
            services.AddDbContext<JtcmContext>
                (options => options.UseSqlServer(localConnection));
            //Services
            services.AddTransient<IWorkflowRoleService, WorkflowRoleSercive>();
            //Repositories
            services.AddTransient<IWorkflowRoleRepository, WorkflowRoleRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
