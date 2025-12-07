
namespace WebApplication1;

/// <summary>
/// https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-8.0&tabs=visual-studio
/// </summary>
public static class SwaggerExtensions
{
    public static IServiceCollection SetupSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen();

        return services;
    }

    public static WebApplication SetupSwagger(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("./swagger/v1/swagger.json", "v1");
                options.RoutePrefix = string.Empty;
            });
        }

        return app;
    }
}