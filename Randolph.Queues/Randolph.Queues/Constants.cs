namespace Randolph.Queues;

public static class Constants
{
    public static class ConnectionStrings
    {
        public const string AzureWebJobsStorage = nameof(AzureWebJobsStorage);

        public const string ServiceBusConnectionString = "ServiceBusSettings:ConnectionString";
    }
    
    public static class QueueNames
    {
        public const string InputQueue = "randolph-input-queue";

        public const string OutputQueue = "randolph-output-queue";
    }
    
    public static class EnvironmentVariables
    {
        public const string CurrentEnvironment = "AZURE_FUNCTIONS_ENVIRONMENT";

        public const string Development = nameof(Development);
    }
    
    public static class FunctionNameSuffixes
    {
        public const string LocalDevelopment = "LocalDev";
    }
}