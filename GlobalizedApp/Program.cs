using System.Globalization;

using GlobalizedApp;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args);
builder.ConfigureServices(services =>
{
    var cultureInfo = new CultureInfo("pt", false);
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
    CultureInfo.CurrentCulture = cultureInfo;

    services.AddLocalization(o => o.ResourcesPath = "Resources");
    services.AddHostedService<ApplicationService>();
});

var host = builder.Build();
host.Run();