
namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Use classic Startup pattern to register services.
            var startup = new Startup(builder.Configuration);
            startup.ConfigureServices(builder.Services);

            var app = builder.Build();

            // Configure middleware/pipeline using Startup
            startup.Configure(app, app.Environment);

            app.Run();
        }
    }
}
