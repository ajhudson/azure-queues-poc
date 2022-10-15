using Microsoft.Extensions.Options;

namespace Randolph.Queues.Settings;

public static class ServiceBusSettings
{
    private static string connectionString = string.Empty;
    
    public static string ConnectionString
    {
        get => connectionString;

        set
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = value;
            }
        }
    }
    
}