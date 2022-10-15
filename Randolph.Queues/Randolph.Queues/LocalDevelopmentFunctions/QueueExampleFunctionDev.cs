using Microsoft.Azure.Functions.Worker;
using Randolph.Queues.Functions;

namespace Randolph.Queues.LocalDevelopmentFunctions;

public sealed class QueueExampleFunctionDev : QueueExampleFunction
{
    [Function(nameof(QueueExample) + Constants.FunctionNameSuffixes.LocalDevelopment)]
    [QueueOutput(Constants.QueueNames.OutputQueue, Connection = Constants.ConnectionStrings.AzureWebJobsStorage)]
    public override string QueueExample(
        [QueueTrigger(Constants.QueueNames.InputQueue, Connection = Constants.ConnectionStrings.AzureWebJobsStorage)]string myQueueItem, 
        FunctionContext context) => base.QueueExample(myQueueItem, context);
}