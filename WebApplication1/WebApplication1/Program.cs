
namespace WebApplication1;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // default
        builder.Services.AddControllers();

        builder.Services.SetupSwagger();

        var app = builder.Build();

        app.SetupSwagger();

        // default
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}
