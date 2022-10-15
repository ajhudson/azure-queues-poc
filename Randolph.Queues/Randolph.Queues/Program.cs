using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Randolph.Queues.Middleware;
using Randolph.Queues.Options;
using Randolph.Queues.Settings;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults((hostBuilderContext, applicationBuilder) =>
    {
        applicationBuilder.UseMiddleware<QueueMiddleware>();
    })
    .ConfigureServices((hostBuilderContext, services) =>
    {
        services.AddOptions<ServiceBusOptions>().Configure<IConfiguration>((settings, cfg) =>
        {
            cfg.GetSection(nameof(ServiceBusOptions)).Bind(settings);
        });

        var serviceProvider = services.BuildServiceProvider();
        var serviceBusSettingsOptions = serviceProvider.GetService<IOptions<ServiceBusOptions>>();
        ServiceBusSettings.ConnectionString = serviceBusSettingsOptions!.Value.ConnectionString;
    })
    .Build();

host.Run();