using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesContacts.Data;

namespace RazorPagesContacts 
{
    public class Startup 
    {
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddMvc();
            services.AddEntityFramework()
            .AddSqlite()
            .AddDbContext<TodoDbContext>();
            
            services.AddIdentity<ToDoUser, IdentityRole>()
            .AddEntityFrameworkStores<TodoDbContext>()
            .AddDefaultTokenProviders();
        }
        
        public void Configure(IApplicationBuilder app) 
        {
            app.UseMvc();
        }
    }
}