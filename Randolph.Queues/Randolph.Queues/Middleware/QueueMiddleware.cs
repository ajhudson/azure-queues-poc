using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Middleware;
using Microsoft.Extensions.Options;
using Randolph.Queues.Options;

namespace Randolph.Queues.Middleware;

public class QueueMiddleware : IFunctionsWorkerMiddleware
{
    public async Task Invoke(FunctionContext context, FunctionExecutionDelegate next)
    {
        var isDevelopment = Environment.GetEnvironmentVariable(Constants.EnvironmentVariables.CurrentEnvironment) == Constants.EnvironmentVariables.Development;

        if (isDevelopment)
        {
            // TODO somehow replace the service bus input binding with a queue input binding
            var ctx = context;


            // TODO somehow replace the service bus output binding with a queue output binding
        }

        await next(context);
    }
}