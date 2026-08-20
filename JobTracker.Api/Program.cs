using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = new WebHostBuilder()
    .UseKestrel()
    .ConfigureAppConfiguration((hostContext) => { })
    .ConfigureServices((context, services) =>
    {
        services.AddControllers();
    })
    .Configure(app =>
    {
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    });

var host = builder.Build();
host.Run();