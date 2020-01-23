using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JTCM.DAL;
using JTCM.DAL.DBModel;
using JTCM.DAL.Interfaces;
using JTCM.DAL.Repositories;
using JTCM.Services;
using JTMC.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var localConnection = @"Server=.;Database=JTCM;User ID=sa;Password=Admin@123+;Trusted_Connection=True;ConnectRetryCount=0";
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddDefaultTokenProviders();

            // Add application services.
        
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
            }

            app.UseStaticFiles();
            app.UseNodeModules(env);
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
