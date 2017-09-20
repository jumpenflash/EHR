using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using EHR.DAL.Inventory.Data;
using EHR.BLL.UnitOfWork.Interfaces;
using EHR.BLL.Inventory.UnitOfWork.Interfaces;
using EHR.DAL.Inventory.Repositories.Interfaces;
using EHR.DAL.Inventory.Repositories;
using EHR.BLL.Inventory.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace EHR.API.Inventory
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
            services.AddDbContext<InventoryContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                //options.UseInMemoryDatabase("InventoryDataBase");
            });

            services.AddTransient<IUnitOfWork, InventoryUnitOfWork>();
            services.AddTransient<IInventoryUnitOfWork, InventoryUnitOfWork>();
            services.AddTransient<ISupplierRepository, SupplierRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
