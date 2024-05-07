using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace GlobalizedApp;

internal class ApplicationService(ILogger<ApplicationService> logger, IStringLocalizer<ApplicationService> localizer) : IHostedService
{
    private readonly IStringLocalizer _localizer = localizer;
    private readonly ILogger<ApplicationService> _logger = logger;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("{msg}", _localizer["STARTING_MESSAGE"]);
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
