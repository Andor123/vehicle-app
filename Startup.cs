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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlite(@"Data Source=IdentitySample.sqlite;");
    }
}