using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCvProjectAPI
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
            services.AddScoped<IGenericService<About>, GenericRepository<About>>();
            services.AddScoped<IGenericService<Comment>, GenericRepository<Comment>>();
            services.AddScoped<IGenericService<Contact>, GenericRepository<Contact>>();
            services.AddScoped<IGenericService<MyProject>, GenericRepository<MyProject>>();
            services.AddScoped<IGenericService<Category>, GenericRepository<Category>>();
			services.AddScoped<IGenericService<User>, GenericRepository<User>>();
            services.AddScoped<IGenericService<NewsletterPerson>, GenericRepository<NewsletterPerson>>();
			services.AddScoped<IGenericService<Like>, GenericRepository<Like>>();
            services.AddScoped<IGenericService<ProjectCategory>, GenericRepository<ProjectCategory>>();
            services.AddScoped<IGenericService<AboutMe>, GenericRepository<AboutMe>>();
            services.AddScoped<IGenericService<CompanyWorkFor>, GenericRepository<CompanyWorkFor>>();
			services.AddScoped<IGenericService<Ability>, GenericRepository<Ability>>();

			services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyCvProjectAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyCvProjectAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
