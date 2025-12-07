
using Serilog;

namespace WebApplication1;

public class Program
{
    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

        var builder = WebApplication.CreateBuilder(args);

        // default
        builder.Services.AddControllers();

        builder.Services.SetupSwagger();

        builder.Services.AddSerilog();

        var app = builder.Build();

        app.SetupSwagger();

        // default
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}
