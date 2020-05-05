using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PointFood.Persistence;
using PointFood.Service;
using PointFood.Service.Impl;

namespace PointFood
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API PointFood",
                    Version = "v1",
                    Description = "Aplicación móvil que permita a los usuarios reservar una mesa en el restaurante, así como registrar una hora aproximada de llegada al establecimiento, la elección de los ingredientes de su platillo y que los mozos tengan el pedido listo, y este a su vez haya sido preparado conforme el cliente haya registrado las especificaciones para su personalización.",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Grupo 3 - PointFood",
                        Email = "grupo3-PointFoood@upc.edu.pe",
                        Url = new Uri("https://github.com/RafaelAnderson/Point-Food"),
                    }
                });
            });


            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(
                opts => opts.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))
                );
            services.AddAutoMapper(typeof(Startup));

            services.AddTransient<ICardService, CardServiceImpl>();
            services.AddTransient<IClientService, ClientServiceImpl>();
            services.AddTransient<IDishService, DishServiceImpl>();
            services.AddTransient<IExtraService, ExtraServiceImpl>();
            services.AddTransient<IOrderService, OrderServiceImpl>();
            services.AddTransient<IRestaurantOwnerService, RestaurantOwnerServiceImpl>();
            services.AddTransient<IRestaurantService, RestaurantServiceImpl>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Point Food V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
