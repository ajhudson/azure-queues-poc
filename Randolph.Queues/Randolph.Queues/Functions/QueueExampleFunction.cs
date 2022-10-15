using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Randolph.Queues.Functions;

public class QueueExampleFunction
{
    [Function(nameof(QueueExample))]
    [ServiceBusOutput(Constants.QueueNames.OutputQueue, Connection = Constants.ConnectionStrings.ServiceBusConnectionString)]
    public virtual string QueueExample(
        [ServiceBusTrigger(Constants.QueueNames.InputQueue, Connection = Constants.ConnectionStrings.ServiceBusConnectionString)]
        string myQueueItem,
        FunctionContext context)
    {
        var logger = context.GetLogger(nameof(QueueExample));
        logger.LogInformation("C# Storage Queue trigger function processed: {Message}", myQueueItem);

        return myQueueItem;
    }
}