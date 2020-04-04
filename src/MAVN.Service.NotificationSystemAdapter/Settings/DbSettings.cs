using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.NotificationSystemAdapter.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
